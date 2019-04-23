using System;
using System.Threading;
using System.Windows.Forms;

namespace Thread1
{
    public partial class Play : Form
    {
        public delegate int delMessage(object sender, string strResult);
        public event delMessage eventdelMessage;

        string _strPlayerName = string.Empty;
        float lapTime = 0;

        public string StrPlayerName
        {
            get
            {
                return _strPlayerName;
            }

            set
            {
                _strPlayerName = value;
            }
        }

        Thread _thread = null;

        bool _bThreadStop = false;


        public Play()
        {
            InitializeComponent();
        }

        public Play(string strPlayerName)
        {
            InitializeComponent();

            lblPlayerName.Text = StrPlayerName = strPlayerName;
        }

        public void fThreadStart()
        {
            _thread = new Thread(Run);
            _thread.Start();
        }

        private void Run()
        {
            //CheckForIllegalCrossThreadCalls = false; //좋은 방식이 절대 아님. CrossThread 무시.

            try
            {
                int Ivar = 0;
                int cycle = 0;

                Random rd = new Random();

                

                while (pbarPlayer.Value < 100 && !_bThreadStop)
                {
                    if (this.InvokeRequired)    //요청한 Thread가 현재 Main Thread가 있는 Control을 엑세스 할 수 있는지 확인
                    {
                        this.Invoke(new Action(delegate ()
                        {

                            //함수값
                            Ivar = rd.Next(1, 11);

                            if (pbarPlayer.Value + Ivar > 100)
                            {
                                pbarPlayer.Value = 100;
                            }
                            else
                            {
                                pbarPlayer.Value = pbarPlayer.Value + Ivar;
                            }

                            lblProcess.Text = string.Format("진행 상황 표시 : {0}%", pbarPlayer.Value);

                            this.Refresh();

                        }));

                        Thread.Sleep(300);
                        cycle++;
                        lapTime = cycle * 0.3f;
                    }
                }

                if (_bThreadStop)
                {
                    eventdelMessage(this, "중도 포기... (Thread Stop), LapTime : "+ lapTime);
                }
                else
                {
                    eventdelMessage(this, "완주!! (Thread Complete), LapTime : " + lapTime);
                }

            }
            catch(ThreadInterruptedException exInterrupt)
            {
                exInterrupt.ToString();
            }
            catch(Exception ex)
            {
                ex.ToString();
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            //ThreadInterrupt();
            if (_thread.IsAlive)
            {
                _bThreadStop = true;
            }
        }

        public void ThreadAbort()
        {
            if (_thread.IsAlive) //Thread 가 동작 중 일 경우
            {
                _thread.Abort(); //Thread 를 강제 종료
            }
        }

        public void ThreadJoin()
        {
            if (_thread.IsAlive)
            {
                bool bThreadEnd = _thread.Join(3000);
            }
        }

        public void ThreadInterrupt()
        {
            if (_thread.IsAlive)
            {
                _thread.Interrupt();
            }
        }
    }
}
