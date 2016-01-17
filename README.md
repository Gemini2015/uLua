# uLua 精简版

基于[jarjin/uLua](https://github.com/jarjin/uLua )，删除一些无用的文件，调整类名与结构。


## 目的

删除与具体项目无关的东西，精简出一个干净的uLua供项目使用。


## 具体修改如下

1.	删除全部示例
1.	`AppConst`改名为`LuaConfig`
1.	日志相关函数全部由`Debugger`类导出
1.	删除部分无用的lua文件