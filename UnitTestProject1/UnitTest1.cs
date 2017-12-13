using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestRensyu;
using System.IO;
using System.Text;

// http://gozuk16.hatenablog.com/entry/2016/05/19/194720
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        string srcPath = @"..\..\source";
        string testPath = @"..\..\test";

        [TestMethod]
        public void TestMethod1()
        {
            var builder = new StringBuilder();

            for (int count = 0; ; count++ )
            {
                string fname = srcPath + count + ".txt";
                if (!File.Exists(fname))
                {
                    break;
                }

                string src = File.ReadAllText(fname);
                //// コンソールを設定
                var reader = new StringReader(src);
                Console.SetIn(reader);

                // 出力の受け取り設定
                builder.Clear();
                var writer = new StringWriter(builder);
                Console.SetOut(writer);

                // テスト実行
                Program.Main(new string[] { "" });

                // テスト結果読み取り
                fname = testPath+count+".txt";
                string expected = File.ReadAllText(fname).Trim();

                // コンソールを読み出す
                var response = new StringReader(builder.ToString());
                string actual = response.ReadToEnd().Trim();

                // チェック
                Assert.AreEqual(expected, actual, "testcase "+count);
            }



        }
    }
}
