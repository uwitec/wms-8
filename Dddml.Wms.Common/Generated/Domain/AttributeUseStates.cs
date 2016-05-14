﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Domain;

using Dddml.Wms.Specialization;

namespace Dddml.Wms.Domain
{

    public class AttributeUseStates : IAttributeUseStates
    {
        
		private Dictionary<AttributeSetAttributeUseId, IAttributeUseState> _loadedAttributeUseStates = new Dictionary<AttributeSetAttributeUseId, IAttributeUseState>();

        private List<IAttributeUseState> _removedAttributeUseStates = new List<IAttributeUseState>();

		protected virtual IEnumerable<IAttributeUseState> LoadedAttributeUseStates {
			get {
				return this._loadedAttributeUseStates.Values;
			}
		}

        private IAttributeSetState _attributeSetState;

        private IEnumerable<IAttributeUseState> _innerEnumerable;

        private IEnumerable<IAttributeUseState> InnerEnumeralbe
        {
            get
            {
                if (_innerEnumerable == null)
                {
                    _innerEnumerable = (ApplicationContext.Current["AttributeUseStateDao"] as IAttributeUseStateDao).FindByAttributeSetId(_attributeSetState.AttributeSetId);
                }
                return _innerEnumerable;
            }
        }

        public AttributeUseStates(IAttributeSetState outerState)
        {
            this._attributeSetState = outerState;
        }

        public IEnumerator<IAttributeUseState> GetEnumerator()
        {
            return InnerEnumeralbe.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return InnerEnumeralbe.GetEnumerator();
        }

        public virtual void Remove(IAttributeUseState state)
        {
            this._removedAttributeUseStates.Add(state);
        }

        public virtual IAttributeUseState Get(string attributeId)
		{
			AttributeSetAttributeUseId globalId = new AttributeSetAttributeUseId(_attributeSetState.AttributeSetId, attributeId);
            if (_loadedAttributeUseStates.ContainsKey(globalId)) {
                return _loadedAttributeUseStates[globalId];
            }
            var state = (ApplicationContext.Current["AttributeUseStateDao"] as IAttributeUseStateDao).Get(globalId);
			_loadedAttributeUseStates.Add (globalId, state);
			return state;
		}

		#region Saveable Implements

		public virtual void Save ()
		{
			foreach (IAttributeUseState s in this.LoadedAttributeUseStates) {
                (ApplicationContext.Current["AttributeUseStateDao"] as IAttributeUseStateDao).Save(s);
			}
            foreach(IAttributeUseState s in this._removedAttributeUseStates)
            {
                (ApplicationContext.Current["AttributeUseStateDao"] as IAttributeUseStateDao).Delete(s);
            }
		}

		#endregion


    }



}

