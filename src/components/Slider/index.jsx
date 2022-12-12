import React from 'react'
import Slider from "react-slick";
import "slick-carousel/slick/slick.css"; 
import "slick-carousel/slick/slick-theme.css";
import CategoryProduct from '../catergory/CategoryProduct';
import "swiper/css";
import "swiper/css/pagination";
import { Swiper, SwiperSlide } from "swiper/react";
import { Pagination, Navigation, Autoplay } from "swiper";
const SliderProduct = () => {
  // const settings = {
  //   dots: false,
  //   infinite: true,
  //   speed: 500,
  //   slidesToShow: 1,
  //   slidesToScroll: 1,
  //   responsive: [
  //     {
  //       breakpoint: 1024,
  //       settings: {
  //         slidesToShow: 1,
  //         slidesToScroll: 1,
  //         infinite: true,
  //         dots: true
  //       }
  //     },
  //     {
  //       breakpoint: 600,
  //       settings: {
  //         slidesToShow: 1,
  //         slidesToScroll: 1,
  //         initialSlide: 1
  //       }
  //     },
  //     {
  //       breakpoint: 480,
  //       settings: {
  //         slidesToShow: 1,
  //         slidesToScroll: 1
  //       }
  //     }
  //   ]
  // };
  return (
    <div>
      <div className="grid grid-cols-12 mt-1">
        <div className="col-span-2">
          <CategoryProduct />
        </div>
        <div className="col-span-10">
            <div className="grid grid-cols-12">
                <div className="col-span-8">
                  <div className="">
                    {/* <Slider {...settings}>
                      <div>
                        <img class="w-100" src="//theme.hstatic.net/1000026716/1000440777/14/slideshow_8.jpg?v=30376" alt="..." />
                      </div>
                      <div>
                        <img class="w-100" src="//theme.hstatic.net/1000026716/1000440777/14/slideshow_12.jpg?v=30376" alt="..." />
                      </div>
                      <div>
                        <img class="w-100" src="//theme.hstatic.net/1000026716/1000440777/14/slideshow_14.jpg?v=30376" alt="..." />
                      </div>
                      <div>
                        <img class="w-100" src="//theme.hstatic.net/1000026716/1000440777/14/slideshow_15.jpg?v=30376" alt="..." />
                      </div>
                      <div>
                        <img class="w-100" src="//theme.hstatic.net/1000026716/1000440777/14/slideshow_2.jpg?v=30376" alt="..." />
                      </div>
                    </Slider> */}
                         <Swiper
                            slidesPerView={1}
                            spaceBetween={10}
                            navigation={true}
                            modules={[Navigation]}
                            breakpoints={{
                              640: {
                                slidesPerView: 1,
                                spaceBetween: 20,
                              },
                              768: {
                                slidesPerView: 1,
                                spaceBetween: 40,
                              },
                              1024: {
                                slidesPerView: 1,
                                spaceBetween: 50,
                              },
                            }}
                            className="mySwiper"
                          >
                            <SwiperSlide>
                              <img class="w-100" src="//theme.hstatic.net/1000026716/1000440777/14/slideshow_8.jpg?v=30376" alt="..." />
                            </SwiperSlide>
                            <SwiperSlide>
                              <img class="w-100" src="//theme.hstatic.net/1000026716/1000440777/14/slideshow_12.jpg?v=30376" alt="..." />
                            </SwiperSlide>
                            <SwiperSlide>
                              <img class="w-100" src="//theme.hstatic.net/1000026716/1000440777/14/slideshow_14.jpg?v=30376" alt="..." />
                            </SwiperSlide>
                            <SwiperSlide>
                              <img class="w-100" src="//theme.hstatic.net/1000026716/1000440777/14/slideshow_15.jpg?v=30376" alt="..." />
                            </SwiperSlide>
                            <SwiperSlide>
                              <img class="w-100" src="//theme.hstatic.net/1000026716/1000440777/14/slideshow_2.jpg?v=30376" alt="..." />
                            </SwiperSlide>
                          </Swiper>
                  </div>
                </div>
                <div className="col-span-4">
                  <div className="">
                    <a href="">
                      <img src="//theme.hstatic.net/1000026716/1000440777/14/solid1.jpg?v=30376" />
                    </a>
                    <a href="">
                      <img src="//theme.hstatic.net/1000026716/1000440777/14/solid2.jpg?v=30376" />
                    </a>
                  </div>
                </div>
            </div>
            <div className="">
              <div className="flex">
                <a href="">
                  <img src="//theme.hstatic.net/1000026716/1000440777/14/solid4.jpg?v=30376" />
               </a>
               <a href="">
                  <img src="//theme.hstatic.net/1000026716/1000440777/14/solid5.jpg?v=30376" />
               </a>
                <a href="">
                 <img src="//theme.hstatic.net/1000026716/1000440777/14/solid4.jpg?v=30376" />
                </a>
                </div>
              </div>
        </div>
      </div>
    </div>
  )
}

export default SliderProduct
