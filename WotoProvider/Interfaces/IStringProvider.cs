﻿
namespace WotoProvider.Interfaces
{
    public interface IStringProvider<T> where T: class
    {
        //-------------------------------------------------
        #region this Region
        char this[int index] { get; }
        #endregion
        //-------------------------------------------------
        #region Properties Region
        int Length { get; }
        bool IsDisposed { get; }
        #endregion
        //-------------------------------------------------
        #region Methods Region
        void ChangeValue(string anotherValue);
        string GetValue();
        void Dispose();
        int IndexOf(string value);
        int IndexOf(char value);
        int IndexOf(T value);
        int ToInt32();
        ushort ToUInt16();
        ulong ToUInt64();
        float ToSingle();
        T GetStrong();
        T[] Split(params string[] separator);
        T[] Split(params T[] separator);
        T Substring(in int startIndex, in int length);
        T Substring(in int startIndex);
        T Remove(in char value);
        T Remove(in int startIndex, in int count);
        T Append(in char value);
        T Append(in string value);
        T Append(in string value, int count);
        T Append(params string[] values);
        T Append(in T value);
        T Append(in T value, int count);
        T Append(params T[] value);
        T Append(in char value, int count);
        #endregion
        //-------------------------------------------------
    }
}
