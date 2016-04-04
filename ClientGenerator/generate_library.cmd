@echo off
setlocal
set PYTHONPATH=%~dp0\src
python -R "%~dp0\src\googleapis\codegen\generate_library.py" %*
