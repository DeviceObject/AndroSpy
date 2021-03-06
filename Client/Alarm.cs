using Android.App;
using Android.Content;

namespace Task2
{
    [IntentFilter(new[] { "MY_ALARM_RECEIVED" })]
    [BroadcastReceiver]
    class Alarm : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            if (intent.Action == "MY_ALARM_RECEIVED")
            {
                if (ForegroundService.mySocketConnected == false)
                {
                    ForegroundService._globalService.cancelAlarm(context);
                    ForegroundService._globalService.Baglanti_Kur();
                }
            }
        }
    }
}