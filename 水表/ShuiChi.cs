using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 水表
{
    class ShuiChi
    {
        private float _long;
        private float _wide;
        private float _height;
        private float _liuliang;

        public ShuiChi() {
            this._long = 1;
            this._wide = 5;
            this._height = 0;
            this._liuliang = 0;
        }

        public void setLiuLiang(int liu) {
            for (int i=0;i<liu;i++) {
                _liuliang++;
            }
            this._height = this._liuliang / (this._long*this._wide);
        }
        public float Long
        {
            get
            {
                return _long;
            }

            set
            {
                _long = value;
            }
        }

        public float Wide
        {
            get
            {
                return _wide;
            }

            set
            {
                _wide = value;
            }
        }

        public float Height
        {
            get
            {
                return _height;
            }

            set
            {
                _height = value;
            }
        }

        public float Liuliang
        {
            get
            {
                return _liuliang;
            }

            set
            {
                _liuliang = value;
            }
        }
    }
}
