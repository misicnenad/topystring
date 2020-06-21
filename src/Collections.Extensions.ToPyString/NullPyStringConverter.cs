﻿namespace Collections.Extensions.ToPyString
{
    class NullPyStringConverter : BasePyStringConverter<object>
    {
        internal NullPyStringConverter(string prefix) : base(null, prefix)
        {
        }

        public override string Convert()
        {
            return Prefix + "null";
        }
    }
}
