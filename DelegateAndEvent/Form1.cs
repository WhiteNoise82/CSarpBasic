using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateAndEvent
{
    public partial class Form1 : Form
    {
        public delegate int delFuncDow_Edge(int i);
        public delegate int delFuncTopping(string strOrder, int Ea);

        int _iTotalPrice = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> dPizzaOrder = new Dictionary<string, int>();

            delFuncDow_Edge delDow = new delFuncDow_Edge(fDow);
            delFuncDow_Edge delEdge = new delFuncDow_Edge(fEdge);

            delFuncTopping delTopping = null;

            int iDowOrder = 0;
            int iEdgeOrder = 0;

            _iTotalPrice = 0;
            lbResult.Items.Clear();

            if (rbOrigin.Checked)
            {
                iDowOrder = 1;
                dPizzaOrder.Add("오리지널",1);
            }
            else if (rbThin.Checked)
            {
                iDowOrder = 2;
                dPizzaOrder.Add("씬", 1);
            }

            delDow.Invoke(iDowOrder);

            if (rbRich.Checked)
            {
                iEdgeOrder = 1;
                dPizzaOrder.Add("리치골드", 1);
            }
            else if (rbCrust.Checked)
            {
                iEdgeOrder = 2;
                dPizzaOrder.Add("치즈크러스터", 1);
            }

            delEdge.Invoke(iEdgeOrder);

            //delDow.Invoke(iDowOrder); ==> fCallBackDelegate(iDowOrder, delDow);
            //delEdge.Invoke(iEdgeOrder); ==> fCallBackDelegate(iEdgeOrder, delEdge);

            if (cbSoce.Checked)
            {
                delTopping += fTopping1;
                dPizzaOrder.Add("소세지", (int)nudEa.Value);
            }

            if (cbPote.Checked)
            {
                delTopping += fTopping2;
                dPizzaOrder.Add("감자", (int)nudEa.Value);
            }

            if (cbChee.Checked)
            {
                delTopping += fTopping3;
                dPizzaOrder.Add("치즈", (int)nudEa.Value);
            }

            if ((cbSoce.Checked|| cbPote.Checked|| cbChee.Checked)&&(nudEa.Value>=1))
            {
                delTopping("토핑", (int)nudEa.Value);
            }

            string strTotal = string.Format("총 주문 금액은 {0} 원 입니다.", _iTotalPrice.ToString());

            fLbOrderRed("-------------------------------------------");
            fLbOrderRed(strTotal);

            frmLoading(dPizzaOrder);
        }

        frmPizza fPizza;

        #region Function

        /// <summary>
        /// 0 : 선택안함, 1 : 오리지널(10000), 2 : 씬(11000)
        /// 0 : 선택안함, 1 : 리치골드(1000), 2 : 치즈크러스터(2000)
        /// 소세지(500), 감자(200), 치즈(300)
        /// </summary>
        /// <param name="iOrder"></param>
        /// <returns></returns>

        private int fDow(int iOrder)
        {
            string strOrder = string.Empty;
            int iPrice = 0;

            if (iOrder == 1)
            {
                iPrice = 10000;
                strOrder = string.Format("도우는 오리지널을 선택 하셨습니다. ({0} 원)", iPrice.ToString());
            }
            else if (iOrder == 2)
            {
                iPrice = 11000;
                strOrder = string.Format("도우는 씬을 선택 하셨습니다. ({0} 원)", iPrice.ToString());
            }
            else
            {
                strOrder = "도우를 선택하지 않았습니다.";
            }

            fLbOrderRed(strOrder);

            return _iTotalPrice += iPrice;
        }

        private int fEdge(int iOrder)
        {
            string strOrder = string.Empty;
            int iPrice = 0;

            if (iOrder == 1)
            {
                iPrice = 1000;
                strOrder = string.Format("엣지는 리치골드를 선택 하셨습니다. ({0} 원)", iPrice.ToString());
            }
            else if (iOrder == 2)
            {
                iPrice = 2000;
                strOrder = string.Format("엣지는 치즈크러스터를 선택 하셨습니다. ({0} 원)", iPrice.ToString());
            }
            else
            {
                strOrder = "엣지를 선택하지 않았습니다.";
            }

            fLbOrderRed(strOrder);

            return _iTotalPrice += iPrice;
        }

        //public int fCallBackDelegate(int i, delFuncDow_Edge dFunction)
        //{
        //    return dFunction(i);
        //}

        private int fTopping1(string Order, int iEa)
        {
            string strOrder = string.Empty;
            int iPrice = iEa * 500;

            strOrder = string.Format("소세지 {0} {1} 개를 선택 하였습니다. : ({2} 원 (1ea 500원)", Order, iEa, iPrice);

            fLbOrderRed(strOrder);

            return _iTotalPrice += iPrice;
        }

        private int fTopping2(string Order, int iEa)
        {
            string strOrder = string.Empty;
            int iPrice = iEa * 200;

            strOrder = string.Format("감자 {0} {1} 개를 선택 하였습니다. : ({2} 원 (1ea 500원)", Order, iEa, iPrice);

            fLbOrderRed(strOrder);

            return _iTotalPrice += iPrice;
        }

        private int fTopping3(string Order, int iEa)
        {
            string strOrder = string.Empty;
            int iPrice = iEa * 300;

            strOrder = string.Format("치즈 {0} {1} 개를 선택 하였습니다. : ({2} 원 (1ea 500원)", Order, iEa, iPrice);

            fLbOrderRed(strOrder);

            return _iTotalPrice += iPrice;
        }

        private void fLbOrderRed(string strOrder)
        {
            lbResult.Items.Add(strOrder);
        }

        #endregion

        #region event 예제

        private void frmLoading(Dictionary<string, int> dPizzaOrder)
        {
            if (fPizza != null)
            {
                fPizza.Dispose();
                fPizza = null;
            }

            fPizza = new frmPizza();
            fPizza.eventdelPizzaComplete += FPizza_eventdelPizzaComplete;
            fPizza.Show();

            fPizza.fPizzaCheck(dPizzaOrder);
        }

        private int FPizza_eventdelPizzaComplete(string strResult, int iTime)
        {
            string strTotal = string.Format("{0} / 걸린 시간 : {1}", strResult, iTime);

            fLbOrderRed("-------------------------------------------");
            fLbOrderRed(strTotal);

            if (iTime > 4000)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        #endregion
    }
}
