# 故障诊断
***
1. 写入失败，并且XShell工具中显示超时.
   + 请检查电脑链接的COM口，可能是电脑COM接触不好，请在电脑上换个好的COM，如果还不行，请换电脑。
   + 可能参数选择错误，软件中要选择正确的COM口和参数。
  <img src="/zh-cn/img/main_help_troubleshooting1.png"/>
   + 如果写入成功，并且在XShell，通过命令重启成功，但是在网站上查不到（测试环境的网址https://ecolinkdmp-d.ecolab.com.cn/#/Device/dtuList），请尝试直接硬重启（对板子断电重启）。
2. 如果写入不成功，请认真检查写入的步骤。例如：如果板子已经存在SN, 原来的SN号是需要删除的。是否需要重启设备等。
3. 写入设备，关联软件和硬件两个方面，如果失败，两个方面都有可能存在问题。
   + 软件请联系软件设计者：xudong.xu@ecolab.com
   + 硬件（Device or Gateway）请联系相关的设计者： jian.zhang3@ecolab.com; ying.zhang@ecolab.com 等
   + 电脑相关问题请联系IT：chinait@ecolab.com
   + SNAndPSK烧制流程请联系：peiguo.yuan@ecolab.com
