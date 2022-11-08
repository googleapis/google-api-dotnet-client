# Updating requirements files

## Updating pip

If you need to update pip itself (which can be useful if other
dependencies fail to install), edit pip-requirements.txt

Find the relevant release in https://pypi.org/project/pip/#files,
and edit pip-requirements.txt with the SHA-256 hash of the *built*
distribution.

## Updating dependencies

`pip-compile` is used to generate the hashes. Install that first,
manually, using a hash from pypi.org.

Edit the requirements.txt file to specify the version of the
dependency you want, then run:

```sh
grep == requirements.txt | sed 's/ \\//g' > requirements.in
rm requirements.txt
pip-compile --generate-hashes requirements.in
rm requirements.in
```
