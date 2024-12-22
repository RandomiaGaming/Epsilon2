namespace EpsilonEngine
{
    public sealed class PhysicsObject
    {
        public Microsoft.Xna.Framework.Graphics.Texture2D _texture;
        public XNAInterface _xnaInterface;
        public int _minX;
        public int _minY;
        public int _maxX;
        public int _maxY;
        public long _positionX;
        public long _positionY;
        public long _velocityX;
        public long _velocityY;
        public int _pixelPositionX
        {
            get
            {
                return (int)(_positionX >> 32);
            }
        }
        public int _pixelPositionY
        {
            get
            {
                return (int)(_positionY >> 32);
            }
        }
        public double _doubleVelocityX
        {
            get
            {
                return _velocityX / 2147483647.0;
            }
            set
            {
                _velocityX = (long)(value * 2147483647.0);
            }
        }
        public double _doubleVelocityY
        {
            get
            {
                return _velocityY / 2147483647.0;
            }
            set
            {
                _velocityY = (long)(value * 2147483647.0);
            }
        }
        public PhysicsObject(PhysicsSimulation simulation)
        {
            simulation._physicsObjects.Add(this);
        }
        public void Claim()
        {

        }
        public void Move()
        {

        }
        public void Draw()
        {
            _xnaInterface.DrawTexture(_texture, _pixelPositionX, _pixelPositionY);
        }
        public void Tick()
        {
            _positionX += _velocityX;
            _positionY += _velocityY;
        }
    }
}
