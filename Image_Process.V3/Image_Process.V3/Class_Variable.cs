using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Image_Process.V3
{
    static public class Class_Variable
    {
        static public Mat[] IMG_Mat = null; //原始圖檔Mat
        static public Mat IMG = null; //原始圖檔
        static public Mat IMG_Gray = null; //轉灰階後的圖檔
        static public Mat IMG_DoWork = null; //準備處理的圖檔
        static public Mat IMG_Operating = null; //處理中的圖檔

    }
}
