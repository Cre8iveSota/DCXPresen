using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SlidesCounter", order = 0)]
public class CurrentSlideIndexMemory : ScriptableObject, ISerializationCallbackReceiver
{
    public int currentSlideNum;
    public Quaternion lastPlayerRotation;
    [SerializeField] private int initcurrentSlideNum = default;
    // Start is called before the first frame update

    public void OnAfterDeserialize()
    {
        // Editor上では再生中に変更したScriptableObject内の値が実行終了時に消えない。
        // そのため、初期値と実行時に使う変数は分けておき、初期化する必要がある。
        currentSlideNum = initcurrentSlideNum;
    }

    public void OnBeforeSerialize() { /* do nothing */ }
}
