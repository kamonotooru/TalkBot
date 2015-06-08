﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TalkBot
{
    public class TalkData
    {
        // コンピューターの表情画像用定数
        public enum Face
        {
            Normal,     // 通常時の顔
            Smile,      // 笑顔
            Angry,      // 怒り顔
            Cry         // 泣き顔
        }


        private List<TalkDataValue> talkDataList = new List<TalkDataValue>();   // 会話で使用する言葉データを保持するリスト



        #region メソッド

        public TalkData()
        {
            // リストの初期化
        }

        /// <summary>
        /// 指定した表情の画像のパスを取得するメソッド
        /// </summary>
        /// <param name="face">表情</param>
        /// <returns>指定した表情画像のファイルパス</returns>
        public string GetImageFilePath(Face face)
        {
            return String.Format("img/Face_{0}.png", face);
        }

        #endregion

        #region プロパティ

        /// <summary>
        /// 会話で使用する言葉のデータリストを取得
        /// </summary>
        public List<TalkDataValue> TalkDataList { get { return talkDataList; } }

        #endregion


        public class TalkDataValue
        {
            /// <summary>入力された文字列（反応文字列）</summary>
            public string InputText { get; set; }

            /// <summary>応答する文字列</summary>
            public string OutputText { get; set; }

            /// <summary>どの表情をするかのフラグ定数</summary>
            public Face FaceImage { get; set; }
        }
    }
}