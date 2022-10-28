# Ecolink_SNPSK_tool 
***
## 使用说明  
> * 登录
>>   1. 选择语言。
>>      <image src="/img/language.png">
>>   2. 选择登录环境。
>>      <image src="/img/env.png">
>>   3. 选择登录方式，两种方式任意选择其中的一种。
>>>    - ECOLink 一键登录。
>>>>    1. 单击ECOLink 一键登录按钮。
>>>>        <image src="/img/ecolinkOneClickLogin_zh.png">
>>>>    2. 自动导航到浏览器，在浏览器中输入自己的账号，然后点击下一步输入密码，然后再输入验证吗。登录成功后，可以关闭浏览器，会自动登录到主窗体。
>>>>          <img src="/img/authentication.png"/>
>>>    - DMP账号登录
>>>>    1. 单击DMP 账号登录。
>>>>      <img src="/img/localAccountLogin.png"/>
>>>>    2. 输入用户名和密码，点击登录。
>>>>      <img src="/img/localAcountLogin_submit.png"/>
>>>>    3. 点击返回按钮，切换登录方式。
>>>>      <img src="/img/localAcountLogin_backup.png"/>

> * 主界面
>> - 账号
>>> + 注销，点击注销菜单，会退出注解面，返回登录界面，可以切换登录的语言，环境和账号。
>>>  <img src="/img/main_signout.png"/>
>> - 串口
>>> + 烧制，主要用来写SN和PSK号。
>>>> 1. 首先选择真确COM设置，然后选择链接.
>>>>  <img src="/img/main_burndown_comsetting.png"/>
>>>> 2. 在发送设置选择正确的发送模式，输入正确的SN号或选择对应的文件。
>>>>>  - 普通发送模式。
>>>>>    <img src="/img/main_burndown_common.png"/>
>>>>>  - 文件发送模式。
>>>>>    <img src="/img/main_burndown_file.png"/>
>>>> 3. 点击烧制按钮，等待返回结果，在接受区会显示成功和失败的结果。
>>>>   <img src="/img/main_burndown_burndown.png"/>
>> - 配置
>>> + 环境（生成环境的配置，只有超级管理，才能操作）
>>>> * 添加，在下边输入框输入对应的值，选择保存。
>>>> <img src="/img/main_env_save.png"/>
>>>> * 删除，在表格的里，点击删除按钮。
>>>> <img src="/img/main_env_delete.png"/>
>>>> * 修改，在表格头部，双击鼠标，对应的值会显示在下边的输入框，然后修改对应的值，点击保存即可。
>>>> <img src="/img/main_env_modify.png"/>
>>> + 应用
>>>> * 添加，在左边对应的输入对应的目标前缀和源前缀，点击保存。（源前缀可以输入框后边的+或-来添加删除新的输入框，目标前缀最多添加8个。）
>>>>  <img src="/img/main_application_add.png"/>
>>>> * 删除，在表格的里，点击删除按钮。
>>>> <img src="/img/main_application_delete.png"/>
>>>> * 修改，在表格头部，双击鼠标，对应的值会显示在左边的输入框，然后修改对应的值，点击保存即可
>>>> <img src="/img/main_application_modify.png"/>
>>>> * 启用。在烧制界面的，选择普通模式发送，选择启用映射前缀。
>>>> <img src="/img/main_application_enable.png"/>
>>> + ADD, 如果使用ECOLink 一键登录,需要配置ADD链接（ADD链接有国过期时间，普通用户只可以查看，超级管理员才可以修改）。
>>> <img src="/img/main_setting_add.png"/>
>> - 帮助



   