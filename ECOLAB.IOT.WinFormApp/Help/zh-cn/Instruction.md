# Ecolink_SNPSK_tool 
***
## 使用说明  
> * 登录
>>   1. 选择语言。
>>      <image src="/zh-cn/img/language.png">
>>   2. 选择登录环境。
>>      <image src="/zh-cn/img/env.png">
>>   3. 选择登录方式，两种方式任意选择其中的一种。
>>>    - ECOLink 一键登录。
>>>>    1. 单击ECOLink一键登录按钮。
>>>>        <image src="/zh-cn/img/ecolinkOneClickLogin.png">
>>>>    2. 自动导航到浏览器，在浏览器中输入自己艺康邮箱作为登录账号，然后点击下一步输入密码，然后再输入验证吗。登录成功后，可以关闭浏览器，会自动登录到主窗体。
>>>>       Note: 第一登录过后，如果Token没有过期，再次登录，则不会跳转到浏览器，会直接登录。如果Token过期，会再次让导航到浏览器。
>>>>    <img src="/zh-cn/img/authentication.png"/>
>>>    - 内部账号登录
>>>>    1. 单击内部账号登录。
>>>>      <img src="/zh-cn/img/localAccountLogin.png"/>
>>>>    2. 输入用户名和密码，点击登录。
>>>>      <img src="/zh-cn/img/localAcountLogin_submit.png"/>
>>>>    3. 点击返回按钮，切换登录方式。
>>>>      <img src="/zh-cn/img/localAcountLogin_backup.png"/>

> * 主界面
>> - 账号
>>> + 注销，点击注销菜单，会退出主界面，返回登录界面，可以切换登录的语言，环境和账号。
>>>  <img src="/zh-cn/img/main_signout.png"/>
>> - 串口
>>> + 烧制，主要用来写SN和PSK号。
>>>> 1. 配置串口参数，选择“链接”连接烧写设备端口.
>>>>  <img src="/zh-cn/img/main_burndown_comsetting.png"/>
>>>> 2. 在发送设置选择正确的发送模式，输入正确的SN号或选择对应的文件。
>>>>>  - 普通发送模式，写SN和PSK到设备上，具体规则如下。
>>>>>    Note:
>>>>>    前缀的显示规则。
>>>>>   `1`. "启用映射前缀"选中
>>>>>       前缀会取前三个字母，然后去匹配"应用ID管理"里的设置，关联出目标前缀。
>>>>>           例如，输入AAA121212123, "应用ID管理"里边设置的目标前缀为SSS, 源前缀为AAA，这里的前缀会显示SSS。
>>>>>   `2`. "启用映射前缀"没有选中
>>>>>      ` `  2.1 如果输入前三个字符是DMC 或者CON ，前缀会显示CON。 
>>>>>      ` `    例如：DMC121212123 或CON121212123，前缀显示DMC.
>>>>>      ` `  2.2 如果不是DMC 或者CON 它显示后边输入框的前三个字符。
>>>>>      ` `    例如: SHG121211223, 前缀是SHG如图所示。
>>>>>        `    `
>>>>>  "启用验证SN"选中时，会对输入的SN号码进行验证。如果没有选中，则不会输入的SN号进行验证。
>>>>>      ` `  规则为:长度为12，前三个字符必须为字母，4-5表示年份，6-7表示月份，8-9表示天，10-12为三位随机数"
>>>>>    <img src="/zh-cn/img/main_burndown_common.png"/>
>>>>>  - 文件发送模式，发送Dragon Gateway的NVRAM配置文件到gateway上。
>>>>>    <img src="/zh-cn/img/main_burndown_file.png"/>
>>>> 3. 点击烧制按钮，等待返回结果，在接受区会显示成功和失败的结果。
>>>>   <img src="/zh-cn/img/main_burndown_burndown.png"/>
>> - 配置
>>> + 环境（生成环境的配置，只有超级管理员，才能操作）
>>>    参数说明：
>>>>      Name: 环境名字，自己定义，请使用英文，例如test,product.
>>>>      ClientID: Keyvalut对应的ClientId,AZURE云里查看。
>>>>      ClientSecret: Keyvalut对应的ClientSecret,AZURE云里查看。
>>>>      TenantId: Keyvalut对应的ClientSecret,AZURE云里查看。
>>>>      KeyVaultUrl: Keyvalut对应的ClientSecret,AZURE云里查看。
>>>>      PlatformName: 注册设备对应的PlatfromName. 
>>>>      DeviceRegisterUrl: 设备的URL（Concierge服务，内部的API）
>>>  
>>>> * 添加，在下边输入框输入对应的值，选择保存。
>>>> <img src="/zh-cn/img/main_env_save.png"/>
>>>> * 删除，在表格的里，点击删除按钮。
>>>> <img src="/zh-cn/img/main_env_delete.png"/>
>>>> * 修改，在表格头部，双击鼠标，对应的值会显示在下边的输入框，然后修改对应的值，点击保存即可。
>>>> <img src="/zh-cn/img/main_env_modify.png"/>
>>> + 应用ID管理.这个页面的作用，为SN的前缀生成指定的AppID做设备号前缀，请参考：“主界面->串口->烧制->2->普通发送模式”章节，里有具体的规则。
>>>> * 添加，在左边对应的输入对应的目标前缀和源前缀，点击保存。（源前缀可以输入框后边的+或-来添加删除新的输入框，目标前缀最多添加8个。）
>>>>  <img src="/zh-cn/img/main_application_add.png"/>
>>>> * 删除，在表格的里，点击删除按钮。
>>>> <img src="/zh-cn/img/main_application_delete.png"/>
>>>> * 修改，在表格头部，双击鼠标，对应的值会显示在左边的输入框，然后修改对应的值，点击保存即可
>>>> <img src="/zh-cn/img/main_application_modify.png"/>
>>>> * 启用。在烧制界面，选择普通模式发送，选择启用映射前缀。
>>>> <img src="/zh-cn/img/main_application_enable.png"/>
>>> + ADD, 如果使用ECOLink一键登录, 需要配置ADD链接（ADD链接有国过期时间，普通用户只可以查看，超级管理员才可以修改）。
>>> <img src="/zh-cn/img/main_setting_add.png"/>
>> - 帮助
>>> + 使用说明
>>> <img src="/zh-cn/img/main_help_Instruction.png"/>  
>>> + 故障排查
>>> <img src="/zh-cn/img/main_help_Troubleshooting.png"/> 