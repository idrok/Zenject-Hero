﻿using System;
using UnityEngine;

namespace Code
{
    public abstract class PlayerState : IDisposable
    {
        public abstract void Update();

        public virtual void Start()
        {
            // optionally overridden.
        }
        
        public virtual void Dispose()
        {
            // optionally overridden.
        }

        public virtual void OnTriggerEnter(Collider other)
        {
            // optionally overridden.
        }
        
    }
}