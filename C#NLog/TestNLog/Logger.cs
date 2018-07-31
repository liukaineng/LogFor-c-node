/*
 * 基于NLog的logger工具类
 */
using NLog;

public static class Logger
    {
    private static readonly ILogger logger = LogManager.GetLogger("Logger");
    public static void Trace(string mes)
    {
        logger.Trace(mes);
    }
    public static void Debug(string mes)
    {
        logger.Debug(mes);
    }
    public static void Info(string mes)
    {
        logger.Info(mes);
    }
    public static void Warn(string mes)
    {
        logger.Info(mes);
    }
    public static void Error(string mes)
    {
        logger.Error(mes);
    }
    public static void Fatal(string mes)
    {
        logger.Fatal(mes);
    }
}

