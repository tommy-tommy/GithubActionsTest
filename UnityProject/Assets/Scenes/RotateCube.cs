using DG.Tweening;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    [SerializeField] float m_rotSpeed = 1f;

    void Start()
    {
        // オブジェクトを左右に移動させる距離
        float moveDistance = 3f;

        // オブジェクトを右に移動
        transform.DOLocalMoveX(moveDistance, 1f)
            .SetLoops(-1, LoopType.Yoyo) // 無限ループ、Yoyoで元の位置に戻る
            .SetEase(Ease.InOutQuad); // イージング効果で自然な動きに
    }

    void Update()
    {
        transform.Rotate(0, m_rotSpeed * Time.deltaTime, 0);
    }
}
