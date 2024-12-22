// Approved 2.0
namespace EpsilonEngine
{
    public sealed class SingleRunPump
    {
        #region Public Variables
        public int EventCount => _eventCount;
        public bool IsEmpty => _pumpEmpty;
        #endregion
        #region Private Variables
        private System.Collections.Generic.List<PumpEvent> _pumpEvents = new System.Collections.Generic.List<PumpEvent>();
        private bool _pumpEmpty = true;
        private int _eventCount = 0;
        #endregion
        #region Public Methods
        public void Invoke()
        {
            if (_pumpEmpty)
            {
                return;
            }
            for (int i = 0; i < _pumpEvents.Count; i++)
            {
                _pumpEvents[i].Invoke();
            }
            _pumpEvents.Clear();
        }
        public void RegisterPumpEvent(PumpEvent pumpEvent, int invokePriority)
        {
            if (pumpEvent is null)
            {
                throw new System.Exception("pumpEvent cannot be null.");
            }
            for (int i = 0; i < _pumpEvents.Count; i++)
            {
                if (pumpEvent == _pumpEvents[i])
                {
                    throw new System.Exception("pumpEvent has already been added to this pump.");
                }
            }
            _pumpEmpty = false;
            _eventCount++;
            _pumpEvents.Add(pumpEvent);
        }
        public bool UnregisterPumpEvent(PumpEvent pumpEvent)
        {
            if (pumpEvent is null)
            {
                throw new System.Exception("pumpEvent cannot be null.");
            }
            for (int i = 0; i < _pumpEvents.Count; i++)
            {
                if (pumpEvent == _pumpEvents[i])
                {
                    _pumpEvents.RemoveAt(i);
                    _eventCount--;
                    if (_eventCount is 0)
                    {
                        _pumpEmpty = true;
                    }
                    return true;
                }
            }
            return false;
        }
        #endregion
        #region Internal Methods
        internal void RegisterPumpEventUnsafe(PumpEvent pumpEvent, int invokePriority)
        {
            _pumpEmpty = false;
            _eventCount++;
            _pumpEvents.Add(pumpEvent);
        }
        internal bool UnregisterPumpEventUnsafe(PumpEvent pumpEvent)
        {
            for (int i = 0; i < _pumpEvents.Count; i++)
            {
                if (pumpEvent == _pumpEvents[i])
                {
                    _pumpEvents.RemoveAt(i);
                    _eventCount--;
                    if (_pumpEvents.Count is 0)
                    {
                        _pumpEmpty = true;
                    }
                    return true;
                }
            }
            return false;
        }
        #endregion
        #region Public Overrides
        public override string ToString()
        {
            return $"EpsilonEngine.SingleRunPump({_eventCount})";
        }
        #endregion
    }
}