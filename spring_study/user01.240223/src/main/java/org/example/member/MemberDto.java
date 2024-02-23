package org.example.member;

import lombok.*;

@Getter
@Setter
@Builder
@AllArgsConstructor
@ToString
public class MemberDto {

    private String email;

    private String name;

    private String password;

    private String confirmPassword;

    public boolean isEqualpassword(){
        return password.equals(confirmPassword);
    }

}
