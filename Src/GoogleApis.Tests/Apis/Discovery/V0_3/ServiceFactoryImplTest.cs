/*
Copyright 2010 Google Inc

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System;
using NUnit.Framework;
using Google.Apis.Discovery;
using Google.Apis.Json;

namespace Google.Apis.Tests.Apis.Discovery.V0_3
{
    /// <summary>
    /// Test for the Discover v0.3 ServiceFactories
    /// </summary>
    [TestFixture]
    public class ServiceFactoryImplTest
    {
        public const string BuzzV0_3_Json =
            @"{
 'name': 'buzz',
 'version': 'v1',
 'description': 'Buzz APIs for Buzz Posts, etc.',
 'restBasePath': '/buzz/v1/',
 'rpcPath': '/rpc',
 'features': [
  'dataWrapper'
 ],
 'schemas': {
  'Activitiylist': {'id':'Activitiylist','properties':{'id':{'type':'any'},'title':{'type':'any'},'items':{'items':{'$ref':'ChiliActivitiesResourceJson'},'type':'array'},'updated':{'type':'string'},'links':{'additionalProperties':{'items':{'properties':{'title':{'type':'any'},'height':{'type':'any'},'count':{'type':'any'},'updated':{'type':'string'},'width':{'type':'any'},'type':{'type':'any'},'href':{'type':'any'}},'type':'object'},'type':'array'},'type':'object'},'kind':{'default':'buzz#activityFeed','type':'string'}},'type':'object'},
  'ChiliActivitiesCountJson': {'id':'ChiliActivitiesCountJson','properties':{'counts':{'additionalProperties':{'items':{'properties':{'timestamp':{'type':'string'},'count':{'type':'any'}},'type':'object'},'type':'array'},'type':'object'},'kind':{'default':'buzz#countFeed','type':'string'}},'type':'object'},
  'ChiliActivitiesExtractpeoplefromsearchJson': {'id':'ChiliActivitiesExtractpeoplefromsearchJson','properties':{'startIndex':{'type':'any'},'totalResults':{'type':'any'},'entry':{'items':{'$ref':'ChiliPeopleResourceJson'},'type':'array'},'itemsPerPage':{'type':'any'},'kind':{'default':'buzz#peopleFeed','type':'string'}},'type':'object'},
  'ChiliActivitiesListJson': {'id':'ChiliActivitiesListJson','$ref':'Activitiylist'},
  'ChiliActivitiesResourceJson': {'id':'ChiliActivitiesResourceJson','properties':{'visibility':{'properties':{'entries':{'items':{'properties':{'id':{'type':'any'},'title':{'type':'any'}},'type':'object'},'type':'array'}},'type':'object'},'placeholder':{'type':'any'},'targetLang':{'type':'any'},'placeName':{'type':'any'},'links':{'additionalProperties':{'items':{'properties':{'title':{'type':'any'},'height':{'type':'any'},'count':{'type':'any'},'updated':{'type':'string'},'width':{'type':'any'},'type':{'type':'any'},'href':{'type':'any'}},'type':'object'},'type':'array'},'properties':{'liked':{'items':{'properties':{'count':{'type':'integer'},'type':{'type':'any'},'href':{'type':'any'}},'type':'object'},'type':'array'}},'type':'object'},'crosspostSource':{'type':'any'},'actor':{'properties':{'id':{'type':'any'},'profileUrl':{'type':'any'},'thumbnailUrl':{'type':'any'},'name':{'type':'any'}},'type':'object'},'object':{'properties':{'untranslatedContent':{'type':'any'},'targetLang':{'type':'any'},'liked':{'items':{'$ref':'ChiliPeopleResourceJson'},'type':'array'},'links':{'additionalProperties':{'items':{'properties':{'type':{'type':'any'},'href':{'type':'any'}},'type':'object'},'type':'array'},'type':'object'},'actor':{'properties':{'id':{'type':'any'},'profileUrl':{'type':'any'},'thumbnailUrl':{'type':'any'},'name':{'type':'any'}},'type':'object'},'type':{'type':'string'},'detectedlLang':{'type':'any'},'shareOriginal':{'$ref':'ChiliActivitiesResourceJson'},'originalContent':{'type':'any'},'id':{'type':'any'},'content':{'type':'any'},'attachments':{'items':{'properties':{'content':{'type':'any'},'id':{'type':'any'},'title':{'type':'any'},'links':{'additionalProperties':{'items':{'properties':{'title':{'type':'any'},'height':{'type':'any'},'count':{'type':'any'},'updated':{'type':'string'},'width':{'type':'any'},'type':{'type':'any'},'href':{'type':'any'}},'type':'object'},'type':'array'},'type':'object'},'type':{'type':'string'}},'type':'object'},'type':'array'},'comments':{'items':{'$ref':'ChiliCommentsResourceJson'},'type':'array'}},'type':'object'},'detectedlLang':{'type':'any'},'kind':{'default':'buzz#activity','type':'string'},'geocode':{'type':'any'},'annotation':{'type':'any'},'id':{'type':'any'},'title':{'type':'any'},'source':{'properties':{'title':{'type':'any'}},'type':'object'},'placeId':{'type':'any'},'address':{'type':'any'},'updated':{'type':'string'},'verbs':{'items':{'type':'string'},'type':'array'},'radius':{'type':'any'},'categories':{'items':{'properties':{'schema':{'type':'any'},'term':{'type':'any'},'label':{'type':'any'}},'type':'object'},'type':'array'},'untranslatedTitle':{'type':'any'},'published':{'type':'string'}},'type':'object'},
  'ChiliActivitiesSearchJson': {'id':'ChiliActivitiesSearchJson','$ref':'Activitiylist'},
  'ChiliActivitiesTrackJson': {'id':'ChiliActivitiesTrackJson','$ref':'Activitiylist'},
  'ChiliCommentsListJson': {'id':'ChiliCommentsListJson','properties':{'id':{'type':'any'},'title':{'type':'any'},'items':{'items':{'$ref':'ChiliCommentsResourceJson'},'type':'array'},'updated':{'type':'string'},'links':{'additionalProperties':{'items':{'properties':{'title':{'type':'any'},'height':{'type':'any'},'count':{'type':'any'},'updated':{'type':'string'},'width':{'type':'any'},'type':{'type':'any'},'href':{'type':'any'}},'type':'object'},'type':'array'},'type':'object'},'kind':{'default':'buzz#commentFeed','type':'string'}},'type':'object'},
  'ChiliCommentsResourceJson': {'id':'ChiliCommentsResourceJson','properties':{'content':{'type':'any'},'id':{'type':'any'},'detectedLang':{'type':'any'},'untranslatedContent':{'type':'any'},'updated':{'type':'string'},'targetLang':{'type':'any'},'placeholder':{'type':'any'},'links':{'additionalProperties':{'items':{'properties':{'title':{'type':'any'},'height':{'type':'any'},'count':{'type':'any'},'updated':{'type':'string'},'width':{'type':'any'},'type':{'type':'any'},'href':{'type':'any'}},'type':'object'},'type':'array'},'properties':{'inReplyTo':{'items':{'properties':{'ref':{'type':'any'},'source':{'type':'any'},'href':{'type':'any'}},'type':'object'},'type':'array'}},'type':'object'},'actor':{'properties':{'id':{'type':'any'},'profileUrl':{'type':'any'},'thumbnailUrl':{'type':'any'},'name':{'type':'any'}},'type':'object'},'published':{'type':'string'},'kind':{'default':'buzz#comment','type':'string'},'originalContent':{'type':'any'}},'type':'object'},
  'ChiliEntitiesListJson': {'id':'ChiliEntitiesListJson','properties':{'entry':{'items':{'$ref':'ChiliEntitiesStarredResource'},'type':'array'},'kind':{'default':'buzz#starredEntityFeed','type':'string'}},'type':'object'},
  'ChiliEntitiesStarredAddJson': {'id':'ChiliEntitiesStarredAddJson','$ref':'ChiliEntitiesStarredResource'},
  'ChiliEntitiesStarredListJson': {'id':'ChiliEntitiesStarredListJson','properties':{'startIndex':{'type':'any'},'totalResults':{'type':'any'},'entry':{'items':{'$ref':'ChiliEntitiesStarredResource'},'type':'array'},'itemsPerPage':{'type':'any'},'kind':{'default':'buzz#starredEntityFeedForUser','type':'string'}},'type':'object'},
  'ChiliEntitiesStarredResource': {'id':'ChiliEntitiesStarredResource','properties':{'summary':{'type':'any'},'id':{'type':'any'},'viewerStarAcl':{'items':{'properties':{'id':{'type':'any'},'tags':{'items':{'type':'any'},'type':'array'},'displayName':{'type':'any'},'kind':{'type':'any'}},'type':'object'},'type':'array'},'title':{'type':'any'},'chipsUiAcl':{'type':'any'},'totalNumStars':{'type':'any'},'starredBy':{'items':{'$ref':'ChiliPeopleResourceJson'},'type':'array'},'starredByViewer':{'type':'any'},'comment':{'type':'any'},'kind':{'default':'buzz#entity','type':'string'}},'type':'object'},
  'ChiliEntitiesdefaultaclResourceJson': {'id':'ChiliEntitiesdefaultaclResourceJson','properties':{'viewerStarAcl':{'items':{'properties':{'id':{'type':'string'},'tags':{'items':{'type':'string'},'type':'array'},'displayName':{'type':'string'},'kind':{'type':'string'}},'type':'object'},'type':'array'},'chipsUiAcl':{'type':'string'},'kind':{'default':'buzz#entityAcl','type':'string'}},'type':'object'},
  'ChiliGroupsListJson': {'id':'ChiliGroupsListJson','properties':{'items':{'items':{'$ref':'ChiliGroupsResourceJson'},'type':'array'},'links':{'additionalProperties':{'items':{'properties':{'title':{'type':'any'},'height':{'type':'any'},'count':{'type':'any'},'updated':{'type':'string'},'width':{'type':'any'},'type':{'type':'any'},'href':{'type':'any'}},'type':'object'},'type':'array'},'type':'object'},'kind':{'default':'buzz#groupFeed','type':'string'}},'type':'object'},
  'ChiliGroupsResourceJson': {'id':'ChiliGroupsResourceJson','properties':{'id':{'type':'any'},'title':{'type':'any'},'links':{'properties':{'self':{'items':{'properties':{'type':{'default':'application/json','type':'string'},'href':{'type':'any'}},'type':'object'},'type':'array'}},'type':'object'},'memberCount':{'type':'any'},'kind':{'default':'buzz#group','type':'string'}},'type':'object'},
  'ChiliPeopleLikedJson': {'id':'ChiliPeopleLikedJson','properties':{'startIndex':{'type':'any'},'totalResults':{'type':'any'},'entry':{'items':{'$ref':'ChiliPeopleResourceJson'},'type':'array'},'itemsPerPage':{'type':'any'},'kind':{'default':'buzz#peopleFeed','type':'string'}},'type':'object'},
  'ChiliPeopleListJson': {'id':'ChiliPeopleListJson','properties':{'startIndex':{'type':'any'},'totalResults':{'type':'any'},'entry':{'items':{'$ref':'ChiliPeopleResourceJson'},'type':'array'},'itemsPerPage':{'type':'any'},'kind':{'default':'buzz#peopleFeed','type':'string'}},'type':'object'},
  'ChiliPeopleResharedJson': {'id':'ChiliPeopleResharedJson','properties':{'startIndex':{'type':'any'},'totalResults':{'type':'any'},'entry':{'items':{'$ref':'ChiliPeopleResourceJson'},'type':'array'},'itemsPerPage':{'type':'any'},'kind':{'default':'buzz#peopleFeed','type':'string'}},'type':'object'},
  'ChiliPeopleResourceJson': {'id':'ChiliPeopleResourceJson','properties':{'turnOffs':{'items':{'type':'any'},'type':'array'},'heroes':{'items':{'type':'any'},'type':'array'},'ims':{'items':{'properties':{'primary':{'type':'any'},'value':{'type':'any'},'type':{'type':'any'}},'type':'object'},'type':'array'},'connected':{'type':'any'},'sports':{'items':{'type':'any'},'type':'array'},'languagesSpoken':{'items':{'type':'any'},'type':'array'},'religion':{'type':'any'},'turnOns':{'items':{'type':'any'},'type':'array'},'languages':{'items':{'type':'any'},'type':'array'},'updated':{'type':'string'},'cars':{'items':{'type':'any'},'type':'array'},'pets':{'items':{'type':'any'},'type':'array'},'gender':{'type':'any'},'humor':{'type':'any'},'activities':{'items':{'type':'any'},'type':'array'},'preferredUsername':{'type':'any'},'hasApp':{'type':'any'},'books':{'items':{'type':'any'},'type':'array'},'happiestWhen':{'type':'any'},'scaredOf':{'type':'any'},'nickname':{'type':'any'},'status':{'type':'any'},'emails':{'items':{'properties':{'primary':{'type':'any'},'value':{'type':'any'},'type':{'type':'any'}},'type':'object'},'type':'array'},'profileUrl':{'type':'any'},'food':{'items':{'type':'any'},'type':'array'},'utcOffset':{'type':'any'},'profileVideo':{'type':'any'},'smoker':{'type':'any'},'addresses':{'items':{'properties':{'region':{'type':'any'},'streetAddress':{'type':'any'},'formatted':{'type':'any'},'postalCode':{'type':'any'},'primary':{'type':'any'},'locality':{'type':'any'},'type':{'type':'any'},'country':{'type':'any'}},'type':'object'},'type':'array'},'birthday':{'type':'any'},'fashion':{'type':'any'},'interests':{'items':{'type':'any'},'type':'array'},'drinker':{'type':'any'},'movies':{'items':{'type':'any'},'type':'array'},'jobInterests':{'items':{'type':'any'},'type':'array'},'children':{'items':{'type':'any'},'type':'array'},'lookingFor':{'type':'any'},'romance':{'type':'any'},'aboutMe':{'type':'any'},'kind':{'default':'buzz#person','type':'string'},'bodyType':{'type':'any'},'id':{'type':'any'},'tvShows':{'items':{'type':'any'},'type':'array'},'name':{'properties':{'middleName':{'type':'any'},'formatted':{'type':'any'},'honorificPrefix':{'type':'any'},'familyName':{'type':'any'},'givenName':{'type':'any'},'honorificSuffix':{'type':'any'}},'type':'object'},'thumbnailUrl':{'type':'any'},'published':{'type':'string'},'relationships':{'items':{'type':'any'},'type':'array'},'profileSong':{'type':'any'},'note':{'type':'any'},'music':{'items':{'type':'any'},'type':'array'},'tags':{'items':{'type':'any'},'type':'array'},'anniversary':{'type':'any'},'politicalViews':{'items':{'type':'any'},'type':'array'},'accounts':{'items':{'properties':{'username':{'type':'any'},'userid':{'type':'any'},'domain':{'type':'any'}},'type':'object'},'type':'array'},'urls':{'items':{'properties':{'primary':{'type':'any'},'value':{'type':'any'},'type':{'type':'any'}},'type':'object'},'type':'array'},'organizations':{'items':{'properties':{'startDate':{'type':'any'},'title':{'type':'any'},'location':{'type':'any'},'description':{'type':'any'},'department':{'type':'any'},'primary':{'type':'any'},'name':{'type':'any'},'endDate':{'type':'any'},'type':{'type':'any'}},'type':'object'},'type':'array'},'relationshipStatus':{'type':'any'},'phoneNumbers':{'items':{'properties':{'primary':{'type':'any'},'value':{'type':'any'},'type':{'type':'any'}},'type':'object'},'type':'array'},'livingArrangement':{'type':'any'},'currentLocation':{'type':'any'},'photos':{'items':{'properties':{'height':{'type':'any'},'width':{'type':'any'},'primary':{'type':'any'},'value':{'type':'any'},'type':{'type':'any'}},'type':'object'},'type':'array'},'quotes':{'items':{'type':'any'},'type':'array'},'sexualOrientation':{'type':'any'},'displayName':{'type':'any'},'ethnicity':{'type':'any'}},'type':'object'},
  'ChiliPeopleSearchJson': {'id':'ChiliPeopleSearchJson','properties':{'startIndex':{'type':'any'},'totalResults':{'type':'any'},'entry':{'items':{'$ref':'ChiliPeopleResourceJson'},'type':'array'},'itemsPerPage':{'type':'any'},'kind':{'default':'buzz#peopleFeed','type':'string'}},'type':'object'},
  'ChiliPhotoalbumsListJson': {'id':'ChiliPhotoalbumsListJson','properties':{'items':{'items':{'$ref':'ChiliPhotoalbumsResourceJson'},'type':'array'},'kind':{'default':'buzz#albumsFeed','type':'string'}},'type':'object'},
  'ChiliPhotoalbumsResourceJson': {'id':'ChiliPhotoalbumsResourceJson','properties':{'tags':{'items':{'type':'string'},'type':'array'},'id':{'type':'integer'},'firstPhotoId':{'type':'integer'},'title':{'type':'string'},'lastModified':{'type':'string'},'created':{'type':'string'},'description':{'type':'string'},'owner':{'properties':{'id':{'type':'string'},'profileUrl':{'type':'string'},'thumbnailUrl':{'type':'string'},'name':{'type':'string'}},'type':'object'},'links':{'properties':{'alternate':{'$ref':'Link'},'enclosure':{'$ref':'Link'}},'type':'object'},'kind':{'default':'buzz#album','type':'string'},'version':{'type':'integer'}},'type':'object'},
  'ChiliPhotosInsertJson': {'id':'ChiliPhotosInsertJson','properties':{'collection':{'properties':{'albumId':{'type':'any'},'album':{'type':'any'},'photo':{'properties':{'photoUrl':{'type':'any'}},'type':'object'}},'type':'object'},'kind':{'default':'buzz#album','type':'string'}},'type':'object'},
  'ChiliPhotosListJson': {'id':'ChiliPhotosListJson','properties':{'items':{'items':{'$ref':'ChiliPhotosResourceJson'},'type':'array'},'kind':{'default':'buzz#photosFeed','type':'string'}},'type':'object'},
  'ChiliPhotosResourceJson': {'id':'ChiliPhotosResourceJson','properties':{'lastModified':{'type':'string'},'album':{'properties':{'id':{'type':'integer'},'page_link':{'$ref':'Link'}},'type':'object'},'links':{'additionalProperties':{'items':{'$ref':'Link'},'type':'array'},'properties':{'alternate':{'items':{'$ref':'Link'},'type':'array'}},'type':'object'},'kind':{'type':'string'},'version':{'type':'integer'},'id':{'type':'integer'},'timestamp':{'type':'number'},'fileSize':{'type':'integer'},'title':{'type':'string'},'created':{'type':'string'},'description':{'type':'string'},'owner':{'properties':{'id':{'type':'string'},'profileUrl':{'type':'string'},'thumbnailUrl':{'type':'string'},'name':{'type':'string'}},'type':'object'},'video':{'$ref':'Video'}},'type':'object'},
  'ChiliRelatedListJson': {'id':'ChiliRelatedListJson','properties':{'id':{'type':'any'},'title':{'type':'any'},'items':{'items':{'$ref':'ChiliRelatedResourceJson'},'type':'array'},'updated':{'type':'string'},'links':{'additionalProperties':{'items':{'properties':{'title':{'type':'any'},'height':{'type':'any'},'count':{'type':'any'},'updated':{'type':'string'},'width':{'type':'any'},'type':{'type':'any'},'href':{'type':'any'}},'type':'object'},'type':'array'},'type':'object'},'kind':{'default':'buzz#relatedFeed','type':'string'}},'type':'object'},
  'ChiliRelatedResourceJson': {'id':'ChiliRelatedResourceJson','properties':{'summary':{'type':'any'},'id':{'type':'any'},'title':{'type':'any'},'href':{'type':'any'},'kind':{'default':'buzz#related','type':'string'}},'type':'object'},
  'ChiliVideosListJson': {'id':'ChiliVideosListJson','properties':{'items':{'items':{'$ref':'ChiliPhotosResourceJson'},'type':'array'},'kind':{'default':'buzz#videosFeed','type':'string'}},'type':'object'},
  'Link': {'id':'Link','properties':{'title':{'type':'string'},'height':{'type':'integer'},'count':{'type':'integer'},'updated':{'type':'string'},'width':{'type':'integer'},'type':{'type':'string'},'href':{'type':'string'}},'type':'object'},
  'Video': {'id':'Video','properties':{'duration':{'type':'integer'},'streams':{'items':{'$ref':'Link'},'type':'array'},'size':{'type':'integer'}},'type':'object'}
 },
 'resources': {
  'activities': {
   'methods': {
    'count': {
     'restPath': 'activities/count',
     'rpcMethod': 'chili.activities.count',
     'httpMethod': 'GET',
     'parameters': {
      'hl': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      }
     },
     'response': {
      '$ref': 'ChiliActivitiesCountJson'
     }
    },
    'delete': {
     'restPath': 'activities/{userId}/{scope}/{postId}',
     'rpcMethod': 'chili.activities.delete',
     'httpMethod': 'DELETE',
     'parameters': {
      'alt': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'hl': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'postId': {
       'restParameterType': 'path',
       'pattern': '.*',
       'required': true,
       'repeated': false
      },
      'scope': {
       'restParameterType': 'path',
       'pattern': '@.*',
       'required': true,
       'repeated': false
      },
      'userId': {
       'restParameterType': 'path',
       'pattern': '[^/]+',
       'required': true,
       'repeated': false
      }
     }
    },
    'extractPeopleFromSearch': {
     'restPath': 'activities/search/@people',
     'rpcMethod': 'chili.activities.extractPeopleFromSearch',
     'httpMethod': 'GET',
     'parameters': {
      'alt': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'bbox': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'c': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'hl': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'lat': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'lon': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'max-results': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'pid': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'q': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'radius': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      }
     },
     'response': {
      '$ref': 'ChiliActivitiesExtractpeoplefromsearchJson'
     }
    },
    'get': {
     'restPath': 'activities/{userId}/@self/{postId}',
     'rpcMethod': 'chili.activities.get',
     'httpMethod': 'GET',
     'parameters': {
      'alt': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'hl': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'postId': {
       'restParameterType': 'path',
       'pattern': '.*',
       'required': true,
       'repeated': false
      },
      'targetLang': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'truncateAtom': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'userId': {
       'restParameterType': 'path',
       'pattern': '[^/]+',
       'required': true,
       'repeated': false
      }
     },
     'response': {
      '$ref': 'ChiliActivitiesResourceJson'
     }
    },
    'insert': {
     'restPath': 'activities/{userId}/@self',
     'rpcMethod': 'chili.activities.insert',
     'httpMethod': 'POST',
     'parameters': {
      'alt': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'hl': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'preview': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'userId': {
       'restParameterType': 'path',
       'pattern': '[^/]+',
       'required': true,
       'repeated': false
      }
     },
     'request': {
      '$ref': 'ChiliActivitiesResourceJson'
     },
     'response': {
      '$ref': 'ChiliActivitiesResourceJson'
     }
    },
    'list': {
     'restPath': 'activities/{userId}/{scope}',
     'rpcMethod': 'chili.activities.list',
     'httpMethod': 'GET',
     'parameters': {
      'alt': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'c': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'hl': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'max-comments': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'max-liked': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'max-results': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'scope': {
       'restParameterType': 'path',
       'pattern': '@(self|public|consumption|liked|comments)*',
       'required': true,
       'repeated': false
      },
      'targetLang': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'truncateAtom': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'userId': {
       'restParameterType': 'path',
       'pattern': '[^/]+',
       'required': true,
       'repeated': false
      }
     },
     'response': {
      '$ref': 'ChiliActivitiesListJson'
     }
    },
    'search': {
     'restPath': 'activities/search',
     'rpcMethod': 'chili.activities.search',
     'httpMethod': 'GET',
     'parameters': {
      'alt': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'bbox': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'c': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'hl': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'lat': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'lon': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'max-results': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'pid': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'q': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'radius': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'targetLang': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'truncateAtom': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      }
     },
     'response': {
      '$ref': 'ChiliActivitiesSearchJson'
     }
    },
    'track': {
     'restPath': 'activities/track',
     'rpcMethod': 'chili.activities.track',
     'httpMethod': 'GET',
     'parameters': {
      'alt': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'bbox': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'c': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'hl': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'lat': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'lon': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'max-results': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'pid': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'q': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'radius': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      }
     },
     'response': {
      '$ref': 'ChiliActivitiesTrackJson'
     }
    },
    'update': {
     'restPath': 'activities/{userId}/{scope}/{postId}',
     'rpcMethod': 'chili.activities.update',
     'httpMethod': 'PUT',
     'parameters': {
      'abuseType': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'alt': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'hl': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'postId': {
       'restParameterType': 'path',
       'pattern': '.*',
       'required': true,
       'repeated': false
      },
      'scope': {
       'restParameterType': 'path',
       'pattern': '@.*',
       'required': true,
       'repeated': false
      },
      'userId': {
       'restParameterType': 'path',
       'pattern': '[^/]+',
       'required': true,
       'repeated': false
      }
     },
     'request': {
      '$ref': 'ChiliActivitiesResourceJson'
     },
     'response': {
      '$ref': 'ChiliActivitiesResourceJson'
     }
    }
   }
  }
 }
}";

        /// <summary>
        /// Tests that the constructor of the service factory will fail when provided with invalid arguments
        /// </summary>
        [Test]
        public void ServiceFactoryDiscovery_ConstructorFailTest()
        {
            var param = new FactoryParameters("http://example.com", "base");
            var json = (JsonDictionary) JsonReader.Parse(BuzzV0_3_Json);

            json = (JsonDictionary) JsonReader.Parse(Discovery.ServiceFactoryImplTest.BadDiscoveryv1_0_No_Name);
            Assert.Throws(typeof(ArgumentException), () => ServiceFactory.Get(DiscoveryVersion.Version_0_3).CreateService(json, param));
        }

        /// <summary>
        /// Tests that the ServiceFactor can be create, and can return a service when provided with a valid argument
        /// </summary>
        [Test]
        public void ServiceFactoryDiscovery_ConstructorSuccessTest()
        {
            var param = new FactoryParameters("http://example.com", "base");
            var json = (JsonDictionary) JsonReader.Parse(BuzzV0_3_Json);
            var fact = ServiceFactory.Get(DiscoveryVersion.Version_0_3);
            var service = fact.CreateService(json, param);

            Assert.IsInstanceOf(typeof(ServiceV0_3), service);
            Assert.That(service.Name, Is.EqualTo("buzz"));
            Assert.That(service.BaseUri.ToString(), Is.EqualTo("http://example.com/base"));
        }
    }
}