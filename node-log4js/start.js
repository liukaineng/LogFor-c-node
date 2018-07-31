const express = require('express'),
bodyParser = require('body-parser'),
path=require("path");
var log4js = require('log4js');


log4js.configure({
    appenders: {
        infoFile: {
            type: 'dateFile',
            filename: "log/infos/info.log"
        },
        info: {
            type: "logLevelFilter",
            level: "info",
            maxLevel :"info",
            appender: "infoFile"
        },
        debugFile: {
            type: 'dateFile',
            filename: 'log/',
            pattern: 'yyyy-MM-dd.log',
            alwaysIncludePattern: true,
        },
        debug: {
            type: "logLevelFilter",
            level: "debug",
            maxLevel :"debug",
            appender: "debugFile"
        },
        errorFile: {
            "type": "file",
            "filename": "log/errors/error.log"
        },
        errors: {
            type: "logLevelFilter",
            level: "error",
            appender: "errorFile"
        }
    },
    categories: {
        default: { appenders: ['info','debug', "errors"], level: 'debug' }
    }
});
var logger = log4js.getLogger();

var app = express();
// bodyParser.urlencoded解析form表单提交的数据
app.use(bodyParser.urlencoded({extended: false})); 
// bodyParser.json解析json数据格式的
app.use(bodyParser.json());

//获取静态资源的
app.use(express.static(path.join(__dirname, '/assets')));


//响应get请求
app.get("/get", function (req, res){
   // console.dir(req.query);
    res.send(req.query);
});

//响应post请求
app.post('/debug',function (req, res){
   // console.dir(req.body);
    logger.debug(req.body);
});

//响应post请求
app.post('/error',function (req, res){
   // console.dir(req.body);
    logger.error(req.body);
});
//将新增用户的信息单独放到体格文件
app.post('/info',function (req, res){
    // console.dir(req.body);
     logger.info(req.body);
 });


var port=1234;
//监听80端口
app.listen(port, function () {
    console.info("web server start ,port:" + port);
});