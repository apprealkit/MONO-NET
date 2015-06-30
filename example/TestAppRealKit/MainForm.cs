using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppRealKit.Realtime;
using AppRealKit.Realtime.Utils.SimpleJSON;

namespace TestAppRealKit
{
    public partial class MainForm : Form
    {
        private String appID_ = "080693ab-7123-4aee-b560-9f6a8a332a43";
        private String appSecret_ = "VORAI5D6yz";
        private String apiHost_ = "192.168.10.102";
        private int apiPort_ = 7777;

        private String loginID_ = "5678";
        private String memberID_ = "1234";

        public MainForm()
        {
            InitializeComponent();
            this.Size = new Size(628, 567);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Add the product ID and secret
            Balancer.Instance.setProductID(appID_, appSecret_);

            //Set the OPEN callback function
            Balancer.Instance.addOpenCallback((object senderChild, AppRealKit.Realtime.State.ClientEventArgs eChild) =>
            {
                MessageBox.Show(Encoding.UTF8.GetString(eChild.arrBytes), "OPENED RESPONSE");
            });

            //Set the MESSAGE callback function
            Balancer.Instance.addReceiveCallback((object senderChild, AppRealKit.Realtime.State.ClientEventArgs eChild) =>
            {
                MessageBox.Show(Encoding.UTF8.GetString(eChild.arrBytes), "PUSH NOTIFICATION RESPONSE");
            });

            //Set the SENT callback function
            Balancer.Instance.addSentCallback((object senderChild, AppRealKit.Realtime.State.ClientEventArgs eChild) =>
            {
                //Nothing
            });

            //Set the CLOSE callback function
            Balancer.Instance.addCloseCallback((object senderChild, AppRealKit.Realtime.State.ClientEventArgs eChild) =>
            {
                MessageBox.Show(Encoding.UTF8.GetString(eChild.arrBytes), "CLOSED RESPONSE");
            });

            //Connection to server
            Balancer.Instance.connect(apiHost_, apiPort_);
        }

        private void btAuthenticate_Click(object sender, EventArgs e)
        {
            Balancer.Instance.authenticate(loginID_, (object senderChild, AppRealKit.Realtime.State.ClientEventArgs eChild) =>
            {
                MessageBox.Show(Encoding.UTF8.GetString(eChild.arrBytes), "AUTHENTICATE RESPONSE");
            });            
        }

        private void btCreateRoom_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> properties = new Dictionary<string,string>();
            properties.Add("name", "ROOM DEMO");
            properties.Add("description", "ROOM DESCRIPTION");
            int iCapacity = 0; //Unlimited members in a ROOM
            Balancer.Instance.createRoom(loginID_, properties, iCapacity, (object senderChild, AppRealKit.Realtime.State.ClientEventArgs eChild) =>
            {
                string sResponse = Encoding.UTF8.GetString(eChild.arrBytes);

                //Parse JSON string to JSON object
                JSONNode jsonObject = JSONNode.Parse(sResponse);

                //Get the body content
                JSONNode jsonDetail = jsonObject[AppRealKit.Realtime.Data.Param.REQUEST_DATA_KEY];

                //Get the roomID
                string roomID = jsonDetail[AppRealKit.Realtime.Data.Param.REQUEST_DATA_ID_KEY];

                //Set the ROOM IS on UI thread
                this.Invoke((MethodInvoker)delegate
                {
                    txtRoomID1.Text = roomID;
                    txtRoomID2.Text = roomID;
                    txtRoomID3.Text = roomID;
                    txtRoomID4.Text = roomID;
                });
               

                //Show DIALOG
                MessageBox.Show(sResponse, "AUTHENTICATE RESPONSE");
            });
        }

        private void btGetLogin_Click(object sender, EventArgs e)
        {
            Balancer.Instance.getUser(loginID_, (object senderChild, AppRealKit.Realtime.State.ClientEventArgs eChild) =>
            {
                MessageBox.Show(Encoding.UTF8.GetString(eChild.arrBytes), "AUTHENTICATE RESPONSE");
            });
        }

        private void btNotifyUser_Click(object sender, EventArgs e)
        {
            string[] arrUser = new string[2];
            arrUser[0] = loginID_;
            arrUser[1] = memberID_;
            int iCode = 1;
            string sReason = "Notify for " + loginID_ + "," + memberID_;
            Boolean ignoreAlertMeFlg = false;
            Balancer.Instance.notifyListUser(arrUser, iCode, sReason, ignoreAlertMeFlg, (object senderChild, AppRealKit.Realtime.State.ClientEventArgs eChild) =>
            {
                MessageBox.Show(Encoding.UTF8.GetString(eChild.arrBytes), "NOTIFY USERS RESPONSE");
            });
        }

        private void btGetRoom_Click(object sender, EventArgs e)
        {
            string roomID = txtRoomID1.Text;
            Balancer.Instance.getRoom(roomID, (object senderChild, AppRealKit.Realtime.State.ClientEventArgs eChild) =>
            {
                MessageBox.Show(Encoding.UTF8.GetString(eChild.arrBytes), "ROOM DETAIL RESPONSE");
            });
        }

        private void btJoinRoom_Click(object sender, EventArgs e)
        {
            string roomID = txtRoomID2.Text;
            Balancer.Instance.joinRoom(memberID_, roomID, (object senderChild, AppRealKit.Realtime.State.ClientEventArgs eChild) =>
            {
                MessageBox.Show(Encoding.UTF8.GetString(eChild.arrBytes), "JOIN ROOM RESPONSE");
            });
        }

        private void btLeaveRoom_Click(object sender, EventArgs e)
        {
            string roomID = txtRoomID3.Text;
            Balancer.Instance.leaveRoom(memberID_, roomID, (object senderChild, AppRealKit.Realtime.State.ClientEventArgs eChild) =>
            {
                MessageBox.Show(Encoding.UTF8.GetString(eChild.arrBytes), "LEAVE ROOM RESPONSE");
            });
        }

        private void btNotifyRoom_Click(object sender, EventArgs e)
        {
            string roomID = txtRoomID3.Text;
            int iCode = 1;
            string sReason = "Notify room " + roomID;
            Boolean ignoreAlertMeFlg = false;
            Balancer.Instance.notifyInRoom(roomID, iCode, sReason, ignoreAlertMeFlg, (object senderChild, AppRealKit.Realtime.State.ClientEventArgs eChild) =>
            {
                MessageBox.Show(Encoding.UTF8.GetString(eChild.arrBytes), "NOTIFY ROOM RESPONSE");
            });
        }
    }
}
