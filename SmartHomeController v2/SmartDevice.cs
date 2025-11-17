using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SmartHomeController
{
    public class SmartDevice
    {
        // Private fields
        private int deviceId;
        private string deviceName;
        private bool status;

        // Public properties
        public int DeviceID
        {
            get { return deviceId; }
            set { deviceId = value; }
        }

        public string DeviceName
        {
            get { return deviceName; }
            set { deviceName = value; }
        }

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        public SmartDevice(int deviceID, string deviceName)
        {
            this.DeviceID = deviceID;
            this.DeviceName = deviceName;
            this.Status = false; // default status for a new smart item

        }

        public void TurnOn()
        {
            status = true;
            Console.WriteLine($"{deviceName} with device ID: {deviceId} is now ON");

        }

        public void TurnOff()
        {
            status = false;
            Console.WriteLine($"{deviceName} with device ID: {deviceId} is now OFF");
        }

        public void GetStatus()
        {
            Console.WriteLine($"Device ID: {DeviceID}, Name {deviceName}, Status (ON or OFF: {(Status ? "ON" : "OFF")}");
        }
    }
}
