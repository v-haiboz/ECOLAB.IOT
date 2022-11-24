# Troubleshooting
***
1. The software cannot be started

    + Defender SmartScreen prevented an unrecognized app from starting.
    <img src="/img/issue1_troubleshotting.png"/>

      Solution steps:
      1. Click Properties
      Right click the installer and click Properties.
      2. Click the small box
      In the open window, find [Unlock] and click [Small Box] in the front
      3. Click OK to unlock the small box in front [Check] and click [OK]

   + The software cannot be started Please ensure that the NET class library is installed on the computer, and the download address (advance to NET6.0): https://dotnet.microsoft.com/en-us/download/dotnet/6.0.
   <img src="/img/issue2_resolve_troubleshooting.png"/>

2. Write failed, and the XShell tool displays timeout.
   + Please check the COM port of the computer link. It may be that the computer COM is not in good contact. Please replace the computer with a good COM. If not, please replace the computer.
   + It is possible that the parameter selection is wrong, and the correct COM port and parameter should be selected in the software.
  <img src="/img/main_help_troubleshooting1.png"/>
   + If the writing is successful, and the XShell is restarted successfully with the command, but it cannot be found on the website (URL of the test environment https://ecolinkdmp-d.ecolab.com.cn/#/Device/dtuList ）, please try hard restart directly (power off and restart the board).

3. If the writing is unsuccessful, please carefully check the writing steps. For example, if SN already exists in the board, the original SN number needs to be deleted. Whether it is necessary to restart the device.

4. How to send the file unsuccessfully? Please check the file size. Currently, the board supports files below 1M.

5. Write device, associated with software and hardware. If it fails, there may be problems in both aspects.
   + For software, please contact the software designer: xudong.xu@ecolab.com
   + For hardware (Device or Gateway), please contact the relevant designer: jian.zhang3@ecolab.com;ying.zhang@ecolab.com;kai.chen@ecolab.com;yi.xiao@ecolab.com Etc
   + For computer related problems, please contact IT: chinait@ecolab.com
   + For SNAndPSK firing process, please contact: peiguo.yuan@ecolab.com
