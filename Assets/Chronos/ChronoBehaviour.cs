using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChronoBehaviour : MonoBehaviour
{
    void Start()
    {
        ChronoStart();
    }

    protected void OnDestroy()
    {
        Chronos.Main.RemoveUpdate(ChronoUpdate);
    }

    protected virtual void ChronoStart() { }
    protected virtual void ChronoUpdate() { }
    protected virtual void ChronoFixedUpdate() { }

    #region IEnumerator

    private void IEnumeratorUpdate()
    {

    }

    public new void StartCoroutine(IEnumerator routine) { }
    public new void StopCoroutine(IEnumerator routine) { }
    public new void StopAllCoroutines() { }

    #endregion
}
