var log4js = require('log4js');
//初始化配置
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

 
exports.logger=logger;
