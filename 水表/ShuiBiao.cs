using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 水表
{
    class ShuiBiao
    {
        private int _hao;
        private int _ge;
        private int _shi;
        private int _bai;
        private int _qing;
        private int _wan;

        public ShuiBiao() {
            this._hao = 0;
            this._ge = 0;
            this._shi = 0;
            this._bai = 0;
            this._qing = 0;
            this._wan = 0;
        }
        public int Hao
        {
            get
            {
                return _hao;
            }

            set
            {
                _hao = value;
            }
        }

        public int Ge
        {
            get
            {
                return _ge;
            }

            set
            {
                _ge = value;
            }
        }

        public int Shi
        {
            get
            {
                return _shi;
            }

            set
            {
                _shi = value;
            }
        }

        public int Bai
        {
            get
            {
                return _bai;
            }

            set
            {
                _bai = value;
            }
        }

        public int Qing
        {
            get
            {
                return _qing;
            }

            set
            {
                _qing = value;
            }
        }

        public int Wan
        {
            get
            {
                return _wan;
            }

            set
            {
                _wan = value;
            }
        }

        public void setNum(int SuDu) {
            for (int i = 0; i < SuDu; i++)
            {
                this.add();
            }
        }

        private void add() {
            this._hao++;
            if (this._hao == 10)
            {
                this._hao = 0;
                this._ge++;
                if (this._ge == 10)
                {
                    this._ge = 0;
                    this._shi++;
                    if (this._shi == 10)
                    {
                        this._shi = 0;
                        this._bai++;
                        if (this._bai == 10)
                        {
                            this._bai = 0;
                            this._qing++;
                            if (this._qing == 10)
                            {
                                this._qing = 0;
                                this._wan++;
                            }
                        }
                    }
                }
            }
        }

    }
}
