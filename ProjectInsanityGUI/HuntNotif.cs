using System;
using System.Collections.Generic;
using System.Text;

public class HuntNotif
{
    public static void SendNotification(string notification)
    {
        Qutan.Config.CurrentNotif = notification;
    }
}
