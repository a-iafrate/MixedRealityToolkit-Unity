﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using Microsoft.MixedReality.Toolkit.Core.Definitions.Utilities;
using Microsoft.MixedReality.Toolkit.Core.Interfaces.Events;
using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Core.Interfaces.SpatialAwarenessSystem
{
    public interface IMixedRealitySpatialAwarenessObserver : IMixedRealityExtensionService, IMixedRealityEventSource
    {
        /// <summary>
        /// Indicates the developer's intended startup behavior.
        /// </summary>
        AutoStartBehavior StartupBehavior { get; set; }

        /// <summary>
        /// Get or sets the default Unity Physics Layer on which to set the spatial object.
        /// </summary>
        int DefaultPhysicsLayer { get; set; }

        /// <summary>
        /// Gets the bit mask that corresponds to the value specified in <see cref="DefaultPhysicsLayer"/>.
        /// </summary>
        int DefaultPhysicsLayerMask { get; }

        /// <summary>
        /// Is the observer running (actively accumulating spatial data)?
        /// </summary>
        bool IsRunning { get; }

        /// <summary>
        /// Should the observer remain stationary in the scene?
        /// </summary>
        /// <remarks>
        /// Set IsStationaryObserver to false to move the volume with the user. 
        /// If set to true, the origin will be 0,0,0 or the last known location.
        /// </remarks>
        bool IsStationaryObserver { get; set; }

        /// <summary>
        /// Gets or sets the size of the volume, in meters per axis, from which individual observations will be made.
        /// </summary>
        Vector3 ObservationExtents { get; set; }

        ///// <summary>
        ///// Gets or sets the orientation of the volume.
        ///// </summary>
        // todo Quaternion ObserverOrientation { get; set }

        /// <summary>
        /// Gets or sets the origin of the observer.
        /// </summary>
        /// <remarks>
        /// Moving the observer origin allows the spatial awareness system to locate and discard meshes as the user
        /// navigates the environment.
        /// </remarks>
        Vector3 ObserverOrigin { get; set; }

        ///// <summary>
        ///// Gets or sets the shape of the observer volume.
        ///// </summary>
        // todo: ObserverVolumeShape ObserverShape { get; set; }


        /// <summary>
        /// Gets or sets the frequency, in seconds, at which the spatial observer should update.
        /// </summary>
        float UpdateInterval { get; set; }

        /// <summary>
        /// Start | resume the observer.
        /// </summary>
        void Resume();

        /// <summary>
        /// Stop | pause the observer
        /// </summary>
        void Suspend();
    }
}