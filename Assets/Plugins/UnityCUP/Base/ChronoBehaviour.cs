using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CUP
{
    public abstract partial class ChronoBehaviour : MonoBehaviour
    {
        Action<bool> OnPauseAction = delegate { };

        void Start()
        {
            Chronos.Main.event_WorldIEnumer += IEnumerUpdate;
            //Optional
            Chronos.Main.event_WorldUpdate += ChronoUpdate;
            Chronos.Main.event_WorldFixedUpdate += ChronoFixedUpdate;
            Chronos.Main.event_WorldOnPause += OnPause;

            ChronoStart();
        }

        protected void OnDestroy()
        {
            Chronos.Main.event_WorldIEnumer -= IEnumerUpdate;
            //Optional
            Chronos.Main.event_WorldUpdate -= ChronoUpdate;
            Chronos.Main.event_WorldFixedUpdate -= ChronoFixedUpdate;
            Chronos.Main.event_WorldOnPause -= OnPause;
        }

        protected void OnPause(bool isMove) => OnPauseAction(isMove);

        protected virtual void ChronoStart() { }
        protected virtual void ChronoUpdate() { }
        protected virtual void ChronoFixedUpdate() { }

        #region IEnumerator

        List<IEnumerator> _numList = new List<IEnumerator>(4);
        List<IEnumerator> remove = new List<IEnumerator>(4);

        private void IEnumerUpdate()
        {
            Waiter waiter = null;
            bool isNull;
            bool isEnd;

            foreach (var num in _numList)
            {
                isNull = num.Current == null;
                isEnd = false;

                if (!isNull)
                {
                    waiter = (num.Current as Waiter);
                    waiter.Timer -= Time.deltaTime;

                    isEnd = waiter.Timer < 0;
                }

                if (isNull | isEnd)
                {
                    if (!num.MoveNext())
                        remove.Add(num);
                }
            }

            foreach (var num in remove)
            {
                _numList.Remove(num);
            }
        }

        public new void StartCoroutine(IEnumerator routine)
        {
            _numList.Add(routine);
        }
        public new void StopCoroutine(IEnumerator routine)
        {
            _numList.Remove(routine);
        }
        public new void StopAllCoroutines()
        {
            _numList = new List<IEnumerator>(4);
        }

        public class Waiter
        {
            public float Timer;

            public Waiter(float sec)
            {
                Timer = sec;
            }
        }
        #endregion
    }
}
