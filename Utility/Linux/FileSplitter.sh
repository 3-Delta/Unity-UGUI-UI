::https://blog.csdn.net/weixin_30510153/article/details/99023584?utm_medium=distribute.pc_relevant_download.none-task-blog-2~default~BlogCommendFromBaidu~default-2.test_version_3&depth_1-utm_source=distribute.pc_relevant_download.none-task-blog-2~default~BlogCommendFromBaidu~default-2.test_version_
:: �ļ����ڣ�if exist %src%
:: �ļ��д��ڣ�if exist %destDir%
:: md, rd��rmdir /S ������ɾ�����ļ��У� ɾ���ļ���
:: touch, del ����ɾ���ļ�

set src=%1
set destDir=%2
:: �ֽ���
set size=%3

echo source: %src%
echo destination��%destDir%
echo size��%size%

:: ���destDir�Ѿ����ڣ�����ɾ���ϵ�
if exist %destDir% (
	rmdir %destDir%
)

split -b %size% destDir

echo Press any key to exit
pause
