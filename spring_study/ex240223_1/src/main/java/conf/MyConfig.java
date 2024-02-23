package conf;

import component.AA;
import component.BB;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;//pom.xml에서 추가를 했기 때문에 @Configulation 쓸 수 있게 됨.
@Configuration
public class MyConfig {
    @Bean
    public AA aa(){
        return new AA();
    }
    @Bean
    public BB bb(){
        return new BB();
    }


}
