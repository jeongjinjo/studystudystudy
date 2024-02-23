package org.example;

import org.example.conf.MyConf;
import org.example.member.MemberDto;
import org.example.member.MemberService;
import org.springframework.context.annotation.AnnotationConfigApplicationContext;

public class Main {

    private static AnnotationConfigApplicationContext acac=null;
    public static void main(String[] args) {

        //insert User 등록
        //list User 조회

        AnnotationConfigApplicationContext acac=
                new AnnotationConfigApplicationContext(MyConf.class);

        processNewCommand();//함수 호출
        processListCommand();

    }

    private static void processListCommand() {
        MemberService ms = acac.getBean(MemberService.class);
        ms.list();


    }

    //왜 이렇게 복잡하게 짜나? 하겠지만 그냥 이 패턴으로 짜야하는게 정해져있다.
    //외우면됨.
    private static void processNewCommand() {
        MemberService ms = acac.getBean(MemberService.class);


        MemberDto md=MemberDto.builder()
                        .email("aaa@naver.com")
                        .name("홍길동")
                        .password("1234")
                        .confirmPassword("1234")
                        .build();

        if(md.isEqualpassword()){
            System.out.println("비밀번호 틀렸다");
            return;
        }

        ms.regist(md);
    }
}