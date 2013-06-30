using System;


namespace ProcessChecker
{
    /**
     * オブジェクトの内容をXMLファイルに保存、復元する: .NET Tips: C#, VB.NET
     * http://dobon.net/vb/dotnet/file/xmlserializer.html
     * */
    class XMLFileManager
    {
        public void save(Data data)
        {
            //保存先のファイル名
            String path = System.IO.Directory.GetCurrentDirectory() + System.IO.Path.DirectorySeparatorChar;
            string fileName = path + @"\setting.xml";
            
            //XmlSerializerオブジェクトを作成
            //オブジェクトの型を指定する
            System.Xml.Serialization.XmlSerializer serializer =
                new System.Xml.Serialization.XmlSerializer(typeof(Data));
            //書き込むファイルを開く
            System.IO.FileStream fs = new System.IO.FileStream(
                fileName, System.IO.FileMode.Create);
            //シリアル化し、XMLファイルに保存する
            serializer.Serialize(fs, data);
            //ファイルを閉じる
            fs.Close();
        }
        public Data load()
        {
            //保存元のファイル名
            String path = System.IO.Directory.GetCurrentDirectory() + System.IO.Path.DirectorySeparatorChar;
            string fileName = path + @"\setting.xml";

            //XmlSerializerオブジェクトを作成
            System.Xml.Serialization.XmlSerializer serializer =
                new System.Xml.Serialization.XmlSerializer(typeof(Data));

            Data data = new Data();
            //読み込むファイルを開く
            try
            {
                System.IO.FileStream fs = new System.IO.FileStream(fileName, System.IO.FileMode.Open);
                //XMLファイルから読み込み、逆シリアル化する
                data = (Data)serializer.Deserialize(fs);
                //ファイルを閉じる
                fs.Close();
            }
            catch (Exception ex)
            {
                // 読めなかったの印
                data.isNull = true;
            }
            return data;
        }
    }
}
