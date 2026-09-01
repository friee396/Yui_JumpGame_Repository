using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  public float MoveSpeed = 2.0f;
  public float JumpPower = 5f;

  private Rigidbody2D rb;


  /*
   * 左右移動
   * - 移動速度
   * 一段ジャンプ
   * - ジャンプ力
   */

  // Start is called before the first frame update
  void Start()
    {
    rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    float x = 0f;

    // ←→ or AD を押すと左右移動
    if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
      {
      x = -1f;
      };
    if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
      {
      x = 1f;
      }

    // 速度＝(左右方向の移動速度, ｙ方向のベクトル)
    rb.velocity = new Vector2(x * MoveSpeed, rb.velocity.y);

    // スペースキーを押すとジャンプ
    if (Input.GetKey(KeyCode.Space))
      {
      rb.velocity = new Vector2(rb.velocity.x, JumpPower);
      }

    }
  }
