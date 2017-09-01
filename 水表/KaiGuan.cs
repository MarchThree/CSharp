namespace 水表
{
    class KaiGuan
    {
        private int _stat;
        private int _suDu;

        public KaiGuan() {
            this._stat = 0;
            this._suDu = 5;
        }

        public int Stat
        {
            get
            {
                return _stat;
            }

            set
            {
                _stat = value;
            }
        }

        public int SuDu
        {
            get
            {
                return _suDu;
            }

            set
            {
                _suDu = value;
            }
        }
    }
}
