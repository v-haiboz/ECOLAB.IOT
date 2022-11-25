# 故障诊断
***
1. 软件不能启动.
   +  Defender SmartScreen阻止了无法识别的应用启动.
   <img src="/img/issue1_troubleshotting.png"/>
   解决步骤：
      1. 点击属性.
         鼠标【右键】点击安装程序，点击【属性】。
      2. 点击小方框.
         在打开的窗口中，找到【解除锁定】，点击前面的【小方框】.
      3. 点击确定, 将解除锁定前面的小方框【勾选】上，点击【确定】即可.
   + 软件不能启动. 请确保电脑上安装了NET类库，下载地址(推进NET6.0)：https://dotnet.microsoft.com/zh-cn/download/dotnet/6.0.
   <img src="/img/issue2_resolve_troubleshooting.png"/>

2. ECOLink一键登录，如果报错，请删除如下的文件(Ecolink_SNPSK_tool.dll.msalcache.bin3)再登录。
   原因：打包的时候，软件还在使用，为了安全问题，登录信息等不能再别的地方使用的，所以不应该打包进去，请退出或者关闭软件再打包。
   <img src="/img/issue_5.png"/>

3. 写入失败，并且XShell工具中显示超时.
   + 请检查电脑链接的COM口，可能是电脑COM接触不好，请在电脑上换个好的COM，如果还不行，请换电脑。
   + 可能参数选择错误，软件中要选择正确的COM口和参数。
  <img src="/img/main_help_troubleshooting1.png"/>
   + 如果写入成功，并且在XShell，通过命令重启成功，但是在网站上查不到（测试环境的网址https://ecolinkdmp-d.ecolab.com.cn/#/Device/dtuList），请尝试直接硬重启（对板子断电重启）。
4. 如果写入不成功，请认真检查写入的步骤。例如：如果板子已经存在SN, 原来的SN号是需要删除的。是否需要重启设备等。

5. 如何文件发送不成功，请检查文件大小，目前板子支持1M一下的文件。

6. 写入设备，关联软件和硬件两个方面，如果失败，两个方面都有可能存在问题。
   + 软件请联系软件设计者：xudong.xu@ecolab.com
   + 硬件（Device or Gateway）请联系相关的设计者：jian.zhang3@ecolab.com;ying.zhang@ecolab.com;kai.chen@ecolab.com;yi.xiao@ecolab.com 等
   + 电脑相关问题请联系IT：chinait@ecolab.com
   + SNAndPSK烧制流程请联系：peiguo.yuan@ecolab.com

