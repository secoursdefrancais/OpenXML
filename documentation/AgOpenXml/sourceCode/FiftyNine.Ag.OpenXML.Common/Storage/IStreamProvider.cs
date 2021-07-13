﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.IO;

namespace FiftyNine.Ag.OpenXML.Common.Storage
{
    public interface IStreamProvider : IDisposable
    {
        Stream GetStream(string path);
        void Close();
    }
}
