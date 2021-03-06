package org.dddml.wms.restful.resource;

import org.dddml.wms.specialization.DomainError;
import org.springframework.http.MediaType;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import java.util.UUID;


/**
 * Created by yangjiefeng on 2018/8/8.
 */
@RequestMapping("tests")
@RestController
public class TestResource {

    @GetMapping(path = "testThrowDomainError", produces = MediaType.APPLICATION_JSON_VALUE)
    public String testThrowDomainError() {
        throw DomainError.named("noname", "Just a test DomainError.");
    }

    @GetMapping(path = "testThrowRuntimeException", produces = MediaType.APPLICATION_JSON_VALUE)
    public String testThrowRuntimeException() {
        throw new RuntimeException("[" + UUID.randomUUID().toString() + "] Just a test RuntimeException.");
    }

}
