using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

/// <summary>
/// Descripción breve de MD5
/// </summary>
public class MD5
{
    public string encriptarMd5(string password)
    {

        System.Security.Cryptography.MD5 md5 = MD5CryptoServiceProvider.Create();

        byte[] dataMd5 = md5.ComputeHash(Encoding.Default.GetBytes(password));

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < dataMd5.Length; i++)
            sb.AppendFormat("{0:x2}", dataMd5[i]);

        return sb.ToString();

    }

    public MD5()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
}