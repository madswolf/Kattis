use std::io;

fn main() {
    let mut hey = String::new();
    let mut result = String::new();
    io::stdin()
        .read_line(&mut hey)
        .expect("could not read line");

    let mut count = 0;
    for x in hey.chars() {
        if x == 'e' || x == 'E'{
            count += 1;
        }
    }
    result.push('h');
    for _i in 0..count {
        result.push_str("ee");
    }
    result.push('y');
    println!("{}",result)
}   