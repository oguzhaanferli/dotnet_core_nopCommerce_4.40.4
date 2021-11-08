﻿using Nop.Plugin.Widgets.Backup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nop.Plugin.Widgets.Backup.Components
{
    class Cron
    {
        private static int First = 0;
        public static Thread _thread;
        public static ManualResetEvent _shutdownEvent = new ManualResetEvent(false);
        public static int time = 0;

        public Cron()
        {
        }
        public Cron(int param)
        {
            time = param;
        }
        public static void ProcessTask()
        {
            try
            {
                DateTime timeLeftCreatedKeys = DateTime.Now;
                while (!_shutdownEvent.WaitOne(0, true))
                {
                    Thread.Sleep(time);
                    try
                    {
                        new SetBackup().Set(true);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //public static void ProcessTaskOran()
        //{
        //    try
        //    {

        //        DateTime timeLeftCreatedKeys = DateTime.Now;
        //        while (!_shutdownEvent.WaitOne(0, true))
        //        {
        //            if (First == 0)
        //            {
        //                Thread.Sleep(300000);
        //                First++;
        //            }
        //            else
        //                Thread.Sleep(86400000);
        //            try
        //            {
        //                new OranDetail().Set();
        //            }
        //            catch (Exception)
        //            {

        //                throw;
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
    }
}
