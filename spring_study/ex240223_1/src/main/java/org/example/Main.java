package org.example;

import component.AA;
import component.BB;
import conf.MyConfig;
import org.springframework.context.annotation.AnnotationConfigApplicationContext;

public class Main {
    public static void main(String[] args) {


        AnnotationConfigApplicationContext context
                =new AnnotationConfigApplicationContext(MyConfig.class);//MyConfig기준으로 객체 담는 통을 만들어라.

        AA aa=context.getBean(AA.class);//폴더가 다르게 되면 import꼭 적어줘야한다.
        BB bb=context.getBean(BB.class);

        System.out.println(aa);
        System.out.println(bb);
    }
}