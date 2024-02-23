package org.example.member;

import lombok.*;

import java.time.LocalDate;




    @AllArgsConstructor
    @ToString
    @Getter
    @Setter
    public class Member {

        private long id;


        private String email;

        private String name;

        private String password;

        private String confirmPassword;

        private LocalDate localDate;


    }

