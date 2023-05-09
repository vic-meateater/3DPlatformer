using System;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : IDisposable
{
    private bool _isDisposed = false;

    private List<BaseController> _childControllers = new();
    private List<GameObject> _childGameObjects = new();

    protected void AddController(BaseController controller)
    {
        _childControllers.Add(controller);
        UpdateController.Add(controller);
    }

    protected void AddGameObject(GameObject go) => _childGameObjects.Add(go);
    protected virtual void OnDisposed() { }

    public void Dispose()
    {
        if (_isDisposed)
            return; 
        
        _isDisposed = true;

        OnDisposed();
        foreach (var controller in _childControllers)
        {
            UpdateController.Remove(controller);
            controller?.Dispose();
        }
        _childControllers.Clear();

        foreach (var gameObject in _childGameObjects)
        {
            if (gameObject != null)
                GameObject.Destroy(gameObject);
        }
        _childGameObjects.Clear();
        
    }
}
