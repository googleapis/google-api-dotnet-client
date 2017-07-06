# Copyright 2015 Google Inc
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# 
#     http://www.apache.org/licenses/LICENSE-2.0
# 
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.

import argparse
import json
from operator import itemgetter
import os
import urllib2


def GetDiscoveryDocuments(destination_dir):
  """Download discovery documents for all Google APIs.

  The discovery documents are saved in destination_dir in files named
  APINAME_VERSION.json (e.g. adexchangebuyer_v1.4.json). Existing files are
  overwritten. The destination directory is created if it doesn't exist.
  """
  discovery_endpoint = 'https://www.googleapis.com/discovery/v1/apis'

  # Make sure the Discovery server never treats us as a Google-internal client.
  headers = {'X-User-Ip': '0.0.0.0'}

  discovery_request = urllib2.Request(discovery_endpoint, headers=headers)
  discovery_json = urllib2.urlopen(discovery_request)
  discovery = json.load(discovery_json)

  if not os.path.exists(destination_dir):
    os.makedirs(destination_dir)

  for api in sorted(discovery['items'], key=itemgetter('name', 'version')):
    filename = '{0}_{1}.json'.format(api['name'], api['version'])
    filename = os.path.join(destination_dir, filename)

    api_url = api['discoveryRestUrl']
    api_request = urllib2.Request(api_url, headers=headers)
    try:
      api_json = urllib2.urlopen(api_request)
    except urllib2.HTTPError:
      print(filename + " FAILED TO DOWNLOAD")
      continue

    # Use binary mode to ensure the file is written exactly as received.
    with open(filename, 'wb') as discovery_file:
      discovery_file.write(api_json.read())

    print(filename)


if __name__ == '__main__':
  args_parser = argparse.ArgumentParser(
      description='Download discovery documents for Google APIs')
  args_parser.add_argument(
    '--destination_dir',
    metavar='DIR',
    default=os.path.join('.', 'DiscoveryJson'),
    help=('Directory to which to write discovery documents\n'
          '(default: .\DiscoveryJson)'))
  args = args_parser.parse_args()
  GetDiscoveryDocuments(args.destination_dir)
