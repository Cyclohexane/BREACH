//
//  Panel.cs
//
//  Author:
//       Justin Bool <booljayj@gmail.com>
//
//  Copyright (c) 2013 
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider))]
public class Panel : MonoBehaviour {
	public Transform camTarget;
	public Vector3 lookOffset;

	void Start() {
		camTarget.LookAt(transform.position+transform.rotation*lookOffset);
	}

	void OnGizmosSelected() {
		Gizmos.DrawSphere(camTarget.position, .01f);
		Gizmos.DrawLine(camTarget.position, transform.position+transform.rotation*lookOffset);
	}
}

