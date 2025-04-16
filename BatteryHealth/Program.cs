// See https://aka.ms/new-console-template for more information
using BatteryHealth;
using System.Text;

BatteryInformation batteryInfo = BatteryInfo.GetBatteryInformation();
StringBuilder sb = new StringBuilder("Battery Information:\n");
sb.AppendLine("Current Capacity: " + batteryInfo.CurrentCapacity + " mWh");
sb.AppendLine("Designed Max Capacity: " + batteryInfo.DesignedMaxCapacity + " mWh");
sb.AppendLine("Full Charge Capacity: " + batteryInfo.FullChargeCapacity + " mWh");
sb.AppendLine("Voltage: " + batteryInfo.Voltage / 1000.0 + " V");
sb.AppendLine("Discharge Rate: " + Math.Abs(batteryInfo.DischargeRate) + " mW");
sb.AppendLine("Battery State: " + batteryInfo.BatteryState);
sb.AppendLine("Battery Health: " + batteryInfo.BatteryHealthPercentage + "%");

Console.WriteLine(sb.ToString());
Console.ReadKey();