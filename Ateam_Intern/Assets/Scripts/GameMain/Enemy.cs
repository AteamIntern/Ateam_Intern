 using UnityEngine;
using System.Collections;
using UniRx;
using UniRx.Triggers;

public class Enemy : MonoBehaviour
{
    public float hpMax { get; private set;}         //最大HP
    public float hpRemain { get; private set; }     //残りHP

    private HpGauge hpGauge;

    void Awake()
    {
        hpMax = 1000;
        hpRemain = hpMax;
        hpGauge = transform.GetComponentInChildren<HpGauge>();
    }

    void Start()
    {
        this.UpdateAsObservable()
            .Select(_ => hpRemain)
            .DistinctUntilChanged()
            .Subscribe(x => hpGauge.ShowAnimation(x/hpMax));
    } 

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            hpRemain -= 100;
        }
    }
	
}
