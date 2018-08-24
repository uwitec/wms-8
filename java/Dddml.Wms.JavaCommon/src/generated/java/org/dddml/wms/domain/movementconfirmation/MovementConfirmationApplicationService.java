package org.dddml.wms.domain.movementconfirmation;

import java.util.Map;
import java.util.List;
import org.dddml.support.criterion.Criterion;
import java.math.BigDecimal;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.Event;
import org.dddml.wms.domain.Command;

public interface MovementConfirmationApplicationService
{
    void when(MovementConfirmationCommand.CreateMovementConfirmation c);

    void when(MovementConfirmationCommand.MergePatchMovementConfirmation c);

    void when(MovementConfirmationCommand.DeleteMovementConfirmation c);

    void when(MovementConfirmationCommands.DocumentAction c);

    MovementConfirmationState get(String id);

    Iterable<MovementConfirmationState> getAll(Integer firstResult, Integer maxResults);

    Iterable<MovementConfirmationState> get(Iterable<Map.Entry<String, Object>> filter, List<String> orders, Integer firstResult, Integer maxResults);

    Iterable<MovementConfirmationState> get(Criterion filter, List<String> orders, Integer firstResult, Integer maxResults);

    Iterable<MovementConfirmationState> getByProperty(String propertyName, Object propertyValue, List<String> orders, Integer firstResult, Integer maxResults);

    long getCount(Iterable<Map.Entry<String, Object>> filter);

    long getCount(Criterion filter);

    MovementConfirmationEvent getEvent(String documentNumber, long version);

    MovementConfirmationState getHistoryState(String documentNumber, long version);

    MovementConfirmationLineState getMovementConfirmationLine(String movementConfirmationDocumentNumber, String lineNumber);

    Iterable<MovementConfirmationLineState> getMovementConfirmationLines(String movementConfirmationDocumentNumber, Criterion filter, List<String> orders);

}

