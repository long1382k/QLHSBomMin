﻿using QLHS.Subform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLHS
{
    class EventForms
    {
        // view toàn bộ hồ sơ
        public void viewToanBoHoSo(int idHoSo, bool btnSaveCloseVisible, bool btnAttackHoSo,
           bool btnAttachFile, bool btnDeleteFileVisible)
        {
            A_ThemHoSo viewHS = new A_ThemHoSo(idHoSo,Option.xem);
            viewHS.BtnSaveClose = btnSaveCloseVisible;
            viewHS.BtnAttachFile = btnAttachFile;
            viewHS.BtnDeleteFile = btnDeleteFileVisible;
            viewHS.ShowDialog();
        }
    }
}
