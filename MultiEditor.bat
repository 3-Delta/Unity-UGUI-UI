::https://zhuanlan.zhihu.com/p/94197105
::Create Dir link

:: https://blog.csdn.net/beechina/article/details/43970169
:: %cd% ��ǰ����ȫ·��
:: set CurrentFolder=%cd%

:: ��ȡ�����ļ�������
for /f "delims=" %%i in ("%cd%") do set folder=%%~ni
echo %folder%

set LINK_DIR=..\%folder%Second

:: @echo off

:: ���dest�ļ��Ѿ����ڣ�����ɾ���ϵ�
if exist %LINK_DIR% (
	rmdir %LINK_DIR%
)

mkdir %LINK_DIR%

:: rmdir %LINK_DIR%\Assets
:: rmdir %LINK_DIR%\ProjectSettings
:: rmdir %LINK_DIR%\Library

mklink /J %LINK_DIR%\Assets Assets
mklink /J %LINK_DIR%\ProjectSettings ProjectSettings
mklink /J %LINK_DIR%\Library Library

pause