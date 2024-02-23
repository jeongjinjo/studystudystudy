package org.example;

import org.example.component.AA;
import org.example.component.BB;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

@Configuration//스프링 객체 담는 통..? IoC컨테이너라고 부른다.
public class AppContext {

    @Bean//이 안에 객체를 넣겠다는 어노테이션
    public AA aa(){return new AA();}

    @Bean
    public BB bb(){
        BB bb=new BB();
        bb.setHi(String.format("%s","안녕하세요"));
        return bb;
    }
}
