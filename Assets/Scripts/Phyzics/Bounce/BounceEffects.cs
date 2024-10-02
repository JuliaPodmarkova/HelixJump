﻿using Structur;
using UnityEngine;

namespace Phyzics.Bounce
{
    public class BounceEffects
    {
        private readonly Rigidbody _rigidbody;
        private readonly BounceData _data;
        private readonly Vector3Curves _scaleCurves;

        public BounceEffects(Rigidbody rigidbody, BounceData data, Vector3Curves scaleCurves)
        {
            _rigidbody = rigidbody;
            _data = data;
            _scaleCurves = scaleCurves;
        }
        public void ApplayUpwardsScaleTo(Transform transform, Vector3 initialScale)
        {
            if (_rigidbody.velocity.y <= 0.0f)
                return;

            float percent = _rigidbody.velocity.y / _data.MaxHeight;

            Vector3 scale = new Vector3
            {
                x = _scaleCurves.XCurve.Evaluate(percent),
                y = _scaleCurves.YCurve.Evaluate(percent),
                z = _scaleCurves.ZCurve.Evaluate(percent)
            };


        }
    } 
}