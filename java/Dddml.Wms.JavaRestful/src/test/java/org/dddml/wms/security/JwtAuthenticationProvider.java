//package org.dddml.wms.security;
//
//import org.springframework.beans.factory.annotation.Autowired;
//import org.springframework.security.authentication.UsernamePasswordAuthenticationToken;
//import org.springframework.security.authentication.dao.AbstractUserDetailsAuthenticationProvider;
//import org.springframework.security.core.AuthenticationException;
//import org.springframework.security.core.userdetails.UserDetails;
//
//
//public class JwtAuthenticationProvider extends AbstractUserDetailsAuthenticationProvider {
//
//    @Autowired
//    private JwtUtil jwtUtil;
//
//    @Override
//    public boolean supports(Class<?> authentication) {
//        return (JwtAuthenticationToken.class.isAssignableFrom(authentication));
//    }
//
//    @Override
//    protected void additionalAuthenticationChecks(UserDetails userDetails, UsernamePasswordAuthenticationToken authentication)
//            throws AuthenticationException {
//    }
//
//    @Override
//    protected UserDetails retrieveUser(String username, UsernamePasswordAuthenticationToken authentication) throws AuthenticationException {
//        JwtAuthenticationToken jwtAuthenticationToken = (JwtAuthenticationToken) authentication;
//        String token = jwtAuthenticationToken.getToken();
//
//        JwtUser parsedUser = jwtUtil.parseToken(token);
//
//        if (parsedUser == null) {
//            throw new JwtTokenMalformedException("JWT token is not valid");
//        }
//        return parsedUser;
//    }
//
//}