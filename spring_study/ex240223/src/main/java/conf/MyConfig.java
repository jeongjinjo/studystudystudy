package conf;

import components.AA;
import components.BB;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
//객체 담는 컨테이너 (IoC)가 만들어진다.
@Configuration
public class MyConfig {
    @Bean
    public
    AA aa(){
        return new AA();
    }
    public BB bb(){
        return new BB();
    }




}
