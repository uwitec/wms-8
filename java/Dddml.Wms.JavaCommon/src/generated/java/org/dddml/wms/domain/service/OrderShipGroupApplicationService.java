// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainServices.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

package org.dddml.wms.domain.service;

import org.dddml.wms.domain.*;

public interface OrderShipGroupApplicationService {

    void when(OrderShipGroupServiceCommands.CreatePOShipGroup c);

    void when(OrderShipGroupServiceCommands.CreateSOShipGroup c);

    String when(OrderShipGroupServiceCommands.CreatePOShipment c);

    String when(OrderShipGroupServiceCommands.CreateSOShipment c);


}

